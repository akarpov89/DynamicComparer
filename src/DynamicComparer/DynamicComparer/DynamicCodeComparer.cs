using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace DynamicComparer
{
    public class DynamicCodeComparer : IEqualityComparer<object>
    {
        private delegate bool Comparer(object x, object y);

        private static Dictionary<Type, Comparer> ComparerCache = new Dictionary<Type, Comparer>();

        public new bool Equals(object x, object y)
        {
            // Если ссылки указывают на один и тот же объект
            if (ReferenceEquals(x, y)) return true;

            // Один из объектов равен null
            if (ReferenceEquals(x, null) != ReferenceEquals(y, null)) return false;

            Type xType = x.GetType();

            // Объекты имеют разные типы
            if (xType != y.GetType()) return false;

            //
            // Проверяем наличие компарера в кэше. Если нет, то создаём его и сохраняем в кэш
            //

            Comparer comparer;
            if (!ComparerCache.TryGetValue(xType, out comparer))
            {
                ComparerCache[xType] = comparer = new ComparerDelegateGenerator().Generate(xType);
            }

            return comparer(x, y);
        }

        public int GetHashCode(object obj)
        {
            return obj.GetHashCode();
        }

        private class ComparerDelegateGenerator
        {
            private ILGenerator il;

            public Comparer Generate(Type type)
            {
                var dynamicMethod = new DynamicMethod("__DynamicCompare", typeof(bool), new[] { typeof(object), typeof(object) });

                il = dynamicMethod.GetILGenerator();

                //
                // Загружаем аргументы и прикастовываем их к типу времени выполнения
                //

                il.LoadFirstArg();
                var arg0 = il.CastToType(type);

                il.LoadSecondArg();
                var arg1 = il.CastToType(type);

                // Сравниваем значения
                CompareValues(type, arg0, arg1);

                // Если управление дошло до этого места, значит объекты равны
                il.ReturnTrue();

                return (Comparer)dynamicMethod.CreateDelegate(typeof(Comparer));
            }

            private void CompareValues(Type type, LocalBuilder x, LocalBuilder y)
            {
                var whenEqual = il.DefineLabel();

                if (!type.IsValueType)
                {
                    JumpIfReferenceEquals(x, y, whenEqual);
                    ReturnFalseIfOneIsNull(x, y);

                    if (type.IsArray)
                    {
                        CompareArrays(type.GetElementType(), x, y);
                    }
                    else if (type.IsClass || type.IsInterface)
                    {
                        if (Type.GetTypeCode(type) == TypeCode.String)
                        {
                            CompareStrings(x, y, whenEqual);
                        }
                        else if (type.IsImplementIEnumerable())
                        {
                            CompareEnumerables(type, x, y);
                        }
                        else
                        {
                            CompareAllProperties(type, x, y);
                        }
                    }
                }
                else if (type.IsNullable())
                {
                    CompareNullableValues(type, x, y, whenEqual);
                }
                else if (type.IsPrimitive)
                {
                    ComparePrimitives(type, x, y, whenEqual);
                }
                else
                {
                    CompareAllProperties(type, x, y);
                }

                il.MarkLabel(whenEqual);
            }

            private void CompareAllProperties(Type type, LocalBuilder x, LocalBuilder y)
            {
                var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
                var readableNonIndexers = properties.Where(p => p.CanRead && p.GetIndexParameters().Length == 0);

                foreach (var property in readableNonIndexers)
                {
                    var leftValue = il.GetPropertyValue(property, x);
                    var rightValue = il.GetPropertyValue(property, y);

                    CompareValues(property.PropertyType, leftValue, rightValue);
                }
            }

            private void CompareArrays(Type elementType, LocalBuilder x, LocalBuilder y)
            {
                var loop = il.DefineLabel();

                il.LoadArrayLength(x);
                il.LoadArrayLength(y);
                il.JumpWhenEqual(loop);
                il.ReturnFalse();

                il.MarkLabel(loop);

                var index = il.DeclareLocal(typeof(int));
                var loopCondition = il.DefineLabel();
                var loopBody = il.DefineLabel();

                il.LoadZero();
                il.SetLocal(index);
                il.Jump(loopCondition);

                il.MarkLabel(loopBody);
                {
                    var xElement = il.GetArrayElement(elementType, x, index);
                    var yElement = il.GetArrayElement(elementType, y, index);
                    CompareValues(elementType, xElement, yElement);
                    il.Increment(index);
                }

                il.MarkLabel(loopCondition);
                {
                    il.LoadLocal(index);
                    il.LoadArrayLength(x);
                    il.JumpWhenLess(loopBody);
                }
            }

            private void CompareEnumerables(Type type, LocalBuilder x, LocalBuilder y)
            {
                var enumerable = type.GetIEnumerableInterface();
                var elementType = enumerable.GetGenericArguments()[0];

                var getEnumeratorMethod = type.GetMethod("GetEnumerator");
                var enumeratorType = getEnumeratorMethod.ReturnType;
                var moveNextMethod = enumeratorType.GetMethod("MoveNext");
                var currentProperty = enumeratorType.GetProperty("Current");

                var firstEnumerator = il.DeclareLocal(enumeratorType);
                var secondEnumerator = il.DeclareLocal(enumeratorType);

                il.LoadLocal(x);
                il.CallVirt(getEnumeratorMethod);
                il.SetLocal(firstEnumerator);

                il.LoadLocal(y);
                il.CallVirt(getEnumeratorMethod);
                il.SetLocal(secondEnumerator);

                var loopCondition = il.DefineLabel();
                var loopBody = il.DefineLabel();
                var end = il.DefineLabel();

                il.Jump(loopCondition);

                il.MarkLabel(loopBody);
                {
                    var xElement = il.GetPropertyValue(currentProperty, firstEnumerator);
                    var yElement = il.GetPropertyValue(currentProperty, secondEnumerator);
                    CompareValues(elementType, xElement, yElement);
                }

                il.MarkLabel(loopCondition);
                {
                    var xCanMoveNext = il.DeclareLocal(typeof(bool));
                    MoveNext(moveNextMethod, firstEnumerator, enumeratorType);
                    il.SetLocal(xCanMoveNext);

                    var yCanMoveNext = il.DeclareLocal(typeof(bool));
                    MoveNext(moveNextMethod, secondEnumerator, enumeratorType);
                    il.SetLocal(yCanMoveNext);

                    il.LoadLocal(xCanMoveNext);
                    il.LoadLocal(yCanMoveNext);
                    il.Emit(OpCodes.And);

                    il.JumpWhenTrue(loopBody);

                    il.LoadLocal(xCanMoveNext);
                    il.LoadLocal(yCanMoveNext);
                    il.CompareEqual();
                    il.JumpWhenTrue(end);
                    il.ReturnFalse();
                }

                il.MarkLabel(end);
            }

            private void MoveNext(MethodInfo moveNextMethod, LocalBuilder enumerator, Type enumeratorType)
            {
                if (enumeratorType.IsValueType)
                {
                    il.LoadLocalAddress(enumerator);
                    il.Call(moveNextMethod);
                }
                else
                {
                    il.LoadLocal(enumerator);
                    il.CallVirt(moveNextMethod);
                }
            }

            private void CompareNullableValues(Type type, LocalBuilder x, LocalBuilder y, Label whenEqual)
            {
                var hasValueProperty = type.GetProperty("HasValue");

                var whenLeftHasValue = il.DefineLabel();
                var whenBothHasValue = il.DefineLabel();

                il.LoadNullableProperty(hasValueProperty, x);
                il.JumpWhenTrue(whenLeftHasValue);

                il.LoadNullableProperty(hasValueProperty, y);
                il.JumpWhenFalse(whenEqual);
                il.ReturnFalse();

                il.MarkLabel(whenLeftHasValue);

                il.LoadNullableProperty(hasValueProperty, y);
                il.JumpWhenTrue(whenBothHasValue);
                il.ReturnFalse();

                il.MarkLabel(whenBothHasValue);

                var valueProperty = type.GetProperty("Value");
                var leftValue = il.GetNullableProperty(valueProperty, x);
                var rightValue = il.GetNullableProperty(valueProperty, y);

                CompareValues(valueProperty.PropertyType, leftValue, rightValue);
            }

            private void JumpIfReferenceEquals(LocalBuilder x, LocalBuilder y, Label whenEqual)
            {
                il.LoadLocal(x);
                il.LoadLocal(y);
                il.JumpWhenEqual(whenEqual);
            }

            private void ReturnFalseIfOneIsNull(LocalBuilder x, LocalBuilder y)
            {
                il.LoadLocal(x);
                il.LoadNull();
                il.CompareEqual();

                il.LoadLocal(y);
                il.LoadNull();
                il.CompareEqual();

                var whenBothNotNull = il.DefineLabel();

                il.JumpWhenEqual(whenBothNotNull);
                il.ReturnFalse();

                il.MarkLabel(whenBothNotNull);
            }

            private void CompareStrings(LocalBuilder x, LocalBuilder y, Label whenEqual)
            {
                var stringEquals = typeof(string).GetMethod("Equals", new[] { typeof(string) });

                il.LoadLocal(x);
                il.LoadLocal(y);
                il.Call(stringEquals);
                il.JumpWhenTrue(whenEqual);
                il.ReturnFalse();
            }

            private void ComparePrimitives(Type type, LocalBuilder x, LocalBuilder y, Label whenEqual)
            {
                if (type == typeof(double) || type == typeof(float))
                {
                    CheckForNaN(type, x, y, whenEqual);
                }

                il.LoadLocal(x);
                il.LoadLocal(y);

                if (type != typeof(IntPtr) && type != typeof(UIntPtr))
                {
                    il.JumpWhenEqual(whenEqual);
                    il.ReturnFalse();
                }
                else
                {
                    var inequalityOperator = type.GetMethod("op_Inequality");
                    il.Call(inequalityOperator);
                    il.JumpWhenFalse(whenEqual);
                    il.ReturnFalse();
                }
            }

            private void CheckForNaN(Type type, LocalBuilder x, LocalBuilder y, Label whenEqual)
            {
                var isNanMethod = type.GetMethod("IsNaN");

                il.LoadLocal(x);
                il.Call(isNanMethod);

                il.LoadLocal(y);
                il.Call(isNanMethod);
                il.Emit(OpCodes.And);
                il.JumpWhenTrue(whenEqual);
            }
        }
    }
}
