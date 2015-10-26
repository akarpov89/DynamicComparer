using System;
using System.Reflection;
using System.Reflection.Emit;

namespace DynamicComparer
{
    public static class GeneratorExtensions
    {
        public static void CompareEqual(this ILGenerator il) => il.Emit(OpCodes.Ceq);

        public static void JumpWhenFalse(this ILGenerator il, Label whenFalse) => il.Emit(OpCodes.Brfalse, whenFalse);
        public static void JumpWhenTrue(this ILGenerator il, Label whenTrue) => il.Emit(OpCodes.Brtrue, whenTrue);
        public static void JumpWhenLess(this ILGenerator il, Label whenLess) => il.Emit(OpCodes.Blt, whenLess);
        public static void Jump(this ILGenerator il, Label label) => il.Emit(OpCodes.Br, label);
        public static void JumpWhenEqual(this ILGenerator il, Label label) => il.Emit(OpCodes.Beq, label);

        public static void LoadZero(this ILGenerator il) => il.Emit(OpCodes.Ldc_I4_0);
        public static void LoadOne(this ILGenerator il) => il.Emit(OpCodes.Ldc_I4_1);
        public static void LoadNull(this ILGenerator il) => il.Emit(OpCodes.Ldnull);

        public static void ReturnFalse(this ILGenerator il)
        {
            il.LoadZero();
            il.Emit(OpCodes.Ret);
        }

        public static void ReturnTrue(this ILGenerator il)
        {
            il.LoadOne();
            il.Emit(OpCodes.Ret);
        }

        public static void LoadFirstArg(this ILGenerator il) => il.Emit(OpCodes.Ldarg_0);
        public static void LoadSecondArg(this ILGenerator il) => il.Emit(OpCodes.Ldarg_1);

        public static LocalBuilder CastToType(this ILGenerator il, Type type)
        {
            var x = il.DeclareLocal(type);
            il.Emit(OpCodes.Castclass, type);
            il.SetLocal(x);
            return x;
        }

        public static void LoadLocal(this ILGenerator il, LocalBuilder x) => il.Emit(OpCodes.Ldloc, x);
        public static void LoadLocalAddress(this ILGenerator il, LocalBuilder x) => il.Emit(OpCodes.Ldloca, x);
        public static void SetLocal(this ILGenerator il, LocalBuilder x) => il.Emit(OpCodes.Stloc, x);

        public static void CallVirt(this ILGenerator il, MethodInfo method) => il.EmitCall(OpCodes.Callvirt, method, null);
        public static void Call(this ILGenerator il, MethodInfo method) => il.EmitCall(OpCodes.Call, method, null);

        public static LocalBuilder GetPropertyValue(this ILGenerator il, PropertyInfo property, LocalBuilder target)
        {
            var x = il.DeclareLocal(property.PropertyType);

            if (target.LocalType.IsValueType)
            {
                il.LoadLocalAddress(target);
                il.Call(property.GetGetMethod());
            }
            else
            {
                il.LoadLocal(target);
                il.CallVirt(property.GetGetMethod());
            }
            il.SetLocal(x);
            return x;
        }

        public static LocalBuilder GetNullableProperty(this ILGenerator il, PropertyInfo property, LocalBuilder target)
        {
            var x = il.DeclareLocal(property.PropertyType);
            il.LoadLocalAddress(target);
            il.Call(property.GetGetMethod());
            il.SetLocal(x);
            return x;
        }

        public static void LoadNullableProperty(this ILGenerator il, PropertyInfo property, LocalBuilder target)
        {
            il.LoadLocalAddress(target);
            il.Call(property.GetGetMethod());
        }

        public static void LoadArrayLength(this ILGenerator il, LocalBuilder array)
        {
            il.LoadLocal(array);
            il.Emit(OpCodes.Ldlen);
            il.Emit(OpCodes.Conv_I4);
        }

        public static void LoadArrayElement(this ILGenerator il) => il.Emit(OpCodes.Ldelem_I4);

        public static LocalBuilder GetArrayElement(this ILGenerator il, Type elementType, LocalBuilder array, LocalBuilder index)
        {
            var x = il.DeclareLocal(elementType);
            il.LoadLocal(array);
            il.LoadLocal(index);
            il.LoadArrayElement();
            il.SetLocal(x);
            return x;
        }

        public static void Increment(this ILGenerator il, LocalBuilder x)
        {
            il.LoadLocal(x);
            il.LoadOne();
            il.Emit(OpCodes.Add);
            il.SetLocal(x);
        }
    }
}