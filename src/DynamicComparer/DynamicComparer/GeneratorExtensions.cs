using System;
using System.Reflection;
using System.Reflection.Emit;

namespace DynamicComparer
{
    public static class GeneratorExtensions
    {
        public static void LoadFirstArg(this ILGenerator il) => il.Emit(OpCodes.Ldarg_0);
        public static void LoadSecondArg(this ILGenerator il) => il.Emit(OpCodes.Ldarg_1);

        public static LocalBuilder CastToType(this ILGenerator il, Type type)
        {
            var x = il.DeclareLocal(type);

            if (type.IsValueType || type.IsPrimitive)
            {
                il.Emit(OpCodes.Unbox_Any, type);
            }
            else
            {
                il.Emit(OpCodes.Castclass, type);
            }

            il.SetLocal(x);
            return x;
        }

        public static void LoadZero(this ILGenerator il) => il.Emit(OpCodes.Ldc_I4_0);
        public static void LoadOne(this ILGenerator il) => il.Emit(OpCodes.Ldc_I4_1);

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

        public static void LoadNull(this ILGenerator il) => il.Emit(OpCodes.Ldnull);

        public static void Compare(this ILGenerator il) => il.Emit(OpCodes.Ceq);

        public static void JumpWhenFalse(this ILGenerator il, Label whenFalse) => il.Emit(OpCodes.Brfalse, whenFalse);
        public static void JumpWhenTrue(this ILGenerator il, Label whenTrue) => il.Emit(OpCodes.Brtrue, whenTrue);
        public static void JumpWhenLess(this ILGenerator il, Label whenLess) => il.Emit(OpCodes.Blt, whenLess);
        public static void JumpWhenEqual(this ILGenerator il, Label label) => il.Emit(OpCodes.Beq, label);
        public static void Jump(this ILGenerator il, Label label) => il.Emit(OpCodes.Br, label);
        
        public static void LoadLocal(this ILGenerator il, LocalBuilder x) => il.Emit(OpCodes.Ldloc, x);
        public static void LoadLocalAddress(this ILGenerator il, LocalBuilder x) => il.Emit(OpCodes.Ldloca, x);
        public static void SetLocal(this ILGenerator il, LocalBuilder x) => il.Emit(OpCodes.Stloc, x);
        
        public static void CallVirt(this ILGenerator il, MethodInfo method) => il.EmitCall(OpCodes.Callvirt, method, null);
        public static void Call(this ILGenerator il, MethodInfo method) => il.EmitCall(OpCodes.Call, method, null);

        public static void LoadPropertyValue(this ILGenerator il, PropertyInfo property, LocalBuilder target)
        {
            if (target.LocalType.IsValueType || target.LocalType.IsNullable())
            {
                il.LoadLocalAddress(target);
                il.Call(property.GetGetMethod());
            }
            else
            {
                il.LoadLocal(target);
                il.CallVirt(property.GetGetMethod());
            }
        }

        public static LocalBuilder GetPropertyValue(this ILGenerator il, PropertyInfo property, LocalBuilder target)
        {
            var x = il.DeclareLocal(property.PropertyType);
            il.LoadPropertyValue(property, target);
            il.SetLocal(x);
            return x;
        }

        public static void LoadArrayLength(this ILGenerator il, LocalBuilder array)
        {
            il.LoadLocal(array);
            il.Emit(OpCodes.Ldlen);
            il.Emit(OpCodes.Conv_I4);
        }

        public static void LoadArrayElement(this ILGenerator il, Type type)
        {
            if (type.IsEnum)
            {
                type = Enum.GetUnderlyingType(type);
            }

            if (type.IsPrimitive)
            {
                if (type == typeof (IntPtr) || type == typeof (UIntPtr))
                {
                    il.Emit(OpCodes.Ldelem_I);
                }
                else
                {
                    OpCode opCode;

                    switch (Type.GetTypeCode(type))
                    {
                        case TypeCode.Boolean:
                        case TypeCode.Int32:
                            opCode = OpCodes.Ldelem_I4;
                            break;
                        case TypeCode.Char:
                        case TypeCode.UInt16:
                            opCode = OpCodes.Ldelem_U2;
                            break;
                        case TypeCode.SByte:
                            opCode = OpCodes.Ldelem_I1;
                            break;
                        case TypeCode.Byte:
                            opCode = OpCodes.Ldelem_U1;
                            break;
                        case TypeCode.Int16:
                            opCode = OpCodes.Ldelem_I2;
                            break;
                        case TypeCode.UInt32:
                            opCode = OpCodes.Ldelem_U4;
                            break;
                        case TypeCode.Int64:
                        case TypeCode.UInt64:
                            opCode = OpCodes.Ldelem_I8;
                            break;
                        case TypeCode.Single:
                            opCode = OpCodes.Ldelem_R4;
                            break;
                        case TypeCode.Double:
                            opCode = OpCodes.Ldelem_R8;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    il.Emit(opCode);
                }
            }
            else if (type.IsValueType)
            {
                il.Emit(OpCodes.Ldelema, type);
            }
            else
            {
                il.Emit(OpCodes.Ldelem_Ref);
            }
        }

        public static LocalBuilder GetArrayElement(this ILGenerator il, Type elementType, LocalBuilder array, LocalBuilder index)
        {
            var x = il.DeclareLocal(elementType);
            il.LoadLocal(array);
            il.LoadLocal(index);
            il.LoadArrayElement(elementType);
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