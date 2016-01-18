using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace DynamicComparer
{
    public class ReflectionComparer : IEqualityComparer<object>
    {
        private static MethodInfo GenericSequenceEqualWithoutComparer = typeof(Enumerable)
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .First(m => m.Name == "SequenceEqual" && m.GetParameters().Length == 2);

        private static MethodInfo GenericSequenceEqualWithComparer = typeof(Enumerable)
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .First(m => m.Name == "SequenceEqual" && m.GetParameters().Length == 3);

        private static MethodInfo GenericCompareArraysMethod =
            typeof(ReflectionComparer).GetMethod(nameof(GenericCompareArrays), BindingFlags.NonPublic | BindingFlags.Static);

        public new bool Equals(object x, object y)
        {
            return CompareObjectsInternal(x?.GetType(), x, y);
        }

        public int GetHashCode(object obj)
        {
            return obj.GetHashCode();
        }

        private bool CompareObjectsInternal(Type type, object x, object y)
        {
            if (ReferenceEquals(x, y)) return true;

            if (ReferenceEquals(x, null) != ReferenceEquals(y, null)) return false;

            if (x.GetType() != y.GetType()) return false;

            if (Type.GetTypeCode(type) == TypeCode.String) return ((string)x).Equals((string)y);

            if (type.IsArray) return CompareArrays(type, x, y);
            
            if (type.IsImplementIEnumerable()) return CompareEnumerables(type, x, y);

            if (type.IsClass || type.IsInterface) return CompareAllProperties(type, x, y);

            if (type.IsPrimitive || type.IsEnum || type == typeof(DateTime)) return x.Equals(y);

            if (type.IsNullable()) return CompareNullables(type, x, y);

            if (type.IsValueType) return CompareAllProperties(type, x, y);

            return x.Equals(y);
        }

        private bool CompareNullables(Type type, object x, object y)
        {
            Type underlyingTypeOfNullableType = Nullable.GetUnderlyingType(type);

            if (underlyingTypeOfNullableType.IsPrimitive)
            {
                return x.Equals(y);
            }

            var valueProperty = type.GetProperty("Value");
            var a = valueProperty.GetValue(x, null);
            var b = valueProperty.GetValue(y, null);

            return CompareAllProperties(underlyingTypeOfNullableType, a, b);
        }

        private bool CompareAllProperties(Type type, object x, object y)
        {
            var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            var readableNonIndexers = properties.Where(p => p.CanRead && p.GetIndexParameters().Length == 0);

            foreach (PropertyInfo propertyInfo in readableNonIndexers)
            {
                var a = propertyInfo.GetValue(x, null);
                var b = propertyInfo.GetValue(y, null);

                if (!CompareObjectsInternal(propertyInfo.PropertyType, a, b)) return false;
            }

            return true;
        }

        private bool CompareEnumerables(Type collectionType, object x, object y)
        {
            Type enumerableInterface = collectionType.GetIEnumerableInterface();
            Type elementType = enumerableInterface.GetGenericArguments()[0];

            MethodInfo sequenceEqual;
            object[] arguments;

            if (elementType.IsPrimitive)
            {
                sequenceEqual = GenericSequenceEqualWithoutComparer;
                arguments = new[] {x, y};
            }
            else
            {
                sequenceEqual = GenericSequenceEqualWithComparer;
                arguments = new[] {x, y, this};
            }

            var sequenceEqualMethod = sequenceEqual.MakeGenericMethod(elementType);

            return (bool)sequenceEqualMethod.Invoke(null, arguments);
        }

        private bool CompareArrays(Type type, object x, object y)
        {
            var elementType = type.GetElementType();
            int xLength, yLength;

            
            if (elementType.IsValueType)
            {
                xLength = ((Array) x).Length;
                yLength = ((Array) y).Length;
            }
            else
            {
                xLength = ((object[]) x).Length;
                yLength = ((object[]) y).Length;
            }

            if (xLength != yLength) return false;

            var compareArraysPrimitive = GenericCompareArraysMethod.MakeGenericMethod(elementType);
            var arguments = elementType.IsPrimitive ? new[] {x, y, null} : new[] {x, y, this};

            return (bool) compareArraysPrimitive.Invoke(null, arguments);
        }

        private static bool GenericCompareArrays<T>(T[] x, T[] y, IEqualityComparer<T> comparer)
        {
            var comp = comparer ?? EqualityComparer<T>.Default;

            for (int i = 0; i < x.Length; ++i)
            {
                if (!comp.Equals(x[i], y[i])) return false;
            }

            return true;
        }
    }
}
