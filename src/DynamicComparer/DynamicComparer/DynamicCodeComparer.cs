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
            // Генератор кода динамического метода
            private ILGenerator il;

            public Comparer Generate(Type type)
            {
                var dynamicMethod = new DynamicMethod("__DynamicCompare", typeof(bool), new[] { typeof(object), typeof(object) }, type.Module);

                il = dynamicMethod.GetILGenerator();

                //
                // Загружаем аргументы и прикастовываем их к типу времени выполнения
                //

                il.LoadFirstArg();
                var arg0 = il.CastToType(type);
                
                il.LoadSecondArg();
                var arg1 = il.CastToType(type);
                
                // Сравниваем значения
                CompareObjectsInternal(type, arg0, arg1);

                // Если управление дошло до этого места, значит объекты равны
                il.ReturnTrue();

                // Создаём делегат для выполнения динамического метода
                return (Comparer)dynamicMethod.CreateDelegate(typeof(Comparer));
            }

            private void CompareObjectsInternal(Type type, LocalBuilder x, LocalBuilder y)
            {
                // Объявляем метку, на которую будем прыгать в случае, если объекты равны
                var whenEqual = il.DefineLabel();

                // Если объекты не являются типами-значений
                if (!type.IsValueType)
                {
                    // Тут же возвращаем true, если ссылки равны между собой
                    JumpIfReferenceEquals(x, y, whenEqual);

                    // Если один из объектов равен null, а второй нет возвращаем false
                    ReturnFalseIfOneIsNull(x, y);

                    // Массивы
                    if (type.IsArray)
                    {
                        CompareArrays(type.GetElementType(), x, y);
                    }
                    // Классы или интерфейсы
                    else if (type.IsClass || type.IsInterface)
                    {
                        // Строки
                        if (Type.GetTypeCode(type) == TypeCode.String)
                        {
                            CompareStrings(x, y, whenEqual);
                        }
                        // Коллекции
                        else if (type.IsImplementIEnumerable())
                        {
                            CompareEnumerables(type, x, y);
                        }
                        // Любые другие классы или интерфейсы
                        else
                        {
                            CompareAllProperties(type, x, y);
                        }
                    }
                }
                // Обнуляемые типы
                else if (type.IsNullable())
                {
                    CompareNullableValues(type, x, y, whenEqual);
                }
                // Примитивные типы или перечисления
                else if (type.IsPrimitive || type.IsEnum)
                {
                    ComparePrimitives(type, x, y, whenEqual);
                }
                // Структуры
                else
                {
                    CompareAllProperties(type, x, y);
                }

                // Ставим метку, на которую будем прыгать в случае, если объекты равны
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

                    CompareObjectsInternal(property.PropertyType, leftValue, rightValue);
                }
            }

            private void CompareArrays(Type elementType, LocalBuilder x, LocalBuilder y)
            {
                var loop = il.DefineLabel();  // Объявляем метку начала цикла сравнения элементов

                il.LoadArrayLength(x);        // Загружаем длину первого массива
                il.LoadArrayLength(y);        // Загружаем длину второго массива
                il.JumpWhenEqual(loop);       // Если длины равны, то переходим к циклу
                il.ReturnFalse();             // Иначе возрвщаем false

                il.MarkLabel(loop);           // Отмечаем метку начала цикла

                var index = il.DeclareLocal(typeof(int)); // Объявляем счётчик цикла - индекс
                var loopCondition = il.DefineLabel();     // Объявляем метку на проверку условия выхода из цикла
                var loopBody = il.DefineLabel();          // Объявляем метку на тело цикла

                il.LoadZero();            // 
                il.SetLocal(index);       // Обнуляем индекс
                il.Jump(loopCondition);   // Прыгаем на проверку условия цикла

                il.MarkLabel(loopBody);   // Отмечаем начало тела цикла
                {
                    var xElement = il.GetArrayElement(elementType, x, index); // Получаем элемент первого массива
                    var yElement = il.GetArrayElement(elementType, y, index); // Получаем элемент второго массива
                    CompareObjectsInternal(elementType, xElement, yElement);  // Сравниваем элементы
                    il.Increment(index);                                      // Увеличиваем счётчик
                }

                il.MarkLabel(loopCondition);     // Отмечаем метку проверки условия выхода из цикла
                {
                    il.LoadLocal(index);         // Загружаем текущее значение  индекса
                    il.LoadArrayLength(x);       // Загружаем длину массива
                    il.JumpWhenLess(loopBody);   // Если индекс не вышел за пределы диапазона, то прыгаем в тело цикла
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
                    CompareObjectsInternal(elementType, xElement, yElement);
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
                    il.Compare();
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

                il.LoadPropertyValue(hasValueProperty, x);
                il.JumpWhenTrue(whenLeftHasValue);

                il.LoadPropertyValue(hasValueProperty, y);
                il.JumpWhenFalse(whenEqual);
                il.ReturnFalse();

                il.MarkLabel(whenLeftHasValue);

                il.LoadPropertyValue(hasValueProperty, y);
                il.JumpWhenTrue(whenBothHasValue);
                il.ReturnFalse();

                il.MarkLabel(whenBothHasValue);

                var valueProperty = type.GetProperty("Value");
                var leftValue = il.GetPropertyValue(valueProperty, x);
                var rightValue = il.GetPropertyValue(valueProperty, y);

                CompareObjectsInternal(valueProperty.PropertyType, leftValue, rightValue);
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
                il.Compare();

                il.LoadLocal(y);
                il.LoadNull();
                il.Compare();

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
