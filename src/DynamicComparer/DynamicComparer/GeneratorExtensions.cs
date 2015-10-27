using System;
using System.Reflection;
using System.Reflection.Emit;

namespace DynamicComparer
{
    public static class GeneratorExtensions
    {
        // Загружает в стек первый аргумент текущего метода
        public static void LoadFirstArg(this ILGenerator il) => il.Emit(OpCodes.Ldarg_0);

        // Загружает в стек второй аргумент текущего метода
        public static void LoadSecondArg(this ILGenerator il) => il.Emit(OpCodes.Ldarg_1);

        // Извлекает из стека значение и приводит его к заданному типу
        public static LocalBuilder CastToType(this ILGenerator il, Type type)
        {
            var x = il.DeclareLocal(type);

            // В случае типов-значений и примитивных типов выполняем распаковку
            if (type.IsValueType || type.IsPrimitive)
            {
                il.Emit(OpCodes.Unbox_Any, type);
            }
            // В случае ссылочных типов выполняем приведение
            else
            {
                il.Emit(OpCodes.Castclass, type);
            }

            il.SetLocal(x);
            return x;
        }

        // Загружает в стек ноль (он же false)
        public static void LoadZero(this ILGenerator il) => il.Emit(OpCodes.Ldc_I4_0);

        // Загружает в стек единицу (она же true)
        public static void LoadOne(this ILGenerator il) => il.Emit(OpCodes.Ldc_I4_1);

        // Возвращает из метода значение false
        public static void ReturnFalse(this ILGenerator il)
        {
            il.LoadZero();
            il.Emit(OpCodes.Ret);
        }

        // Возвращает из метода значение true
        public static void ReturnTrue(this ILGenerator il)
        {
            il.LoadOne();
            il.Emit(OpCodes.Ret);
        }

        // Загружает в стек null
        public static void LoadNull(this ILGenerator il) => il.Emit(OpCodes.Ldnull);

        // Извлекает из стека два значения и помещает в стек результат их сравнения
        public static void Compare(this ILGenerator il) => il.Emit(OpCodes.Ceq);

        // Извлекает из стека значение, если это false, то прыгает на заданную метку
        public static void JumpWhenFalse(this ILGenerator il, Label whenFalse) => il.Emit(OpCodes.Brfalse_S, whenFalse);

        // Извлекает из стека значение, если это true, то прыгает на заданную метку
        public static void JumpWhenTrue(this ILGenerator il, Label whenTrue) => il.Emit(OpCodes.Brtrue_S, whenTrue);

        // Извлекает из стека два значения, и если первое меньше второго, то прыгает на заданную метку
        public static void JumpWhenLess(this ILGenerator il, Label whenLess) => il.Emit(OpCodes.Blt_S, whenLess);

        // Извлекает из стека два значения, и если они равны, то прыгает на заданную метку
        public static void JumpWhenEqual(this ILGenerator il, Label label) => il.Emit(OpCodes.Beq_S, label);

        // Прыгает на заданную метку
        public static void Jump(this ILGenerator il, Label label) => il.Emit(OpCodes.Br_S, label);
        
        // Загружает в стек значение заданной переменной
        public static void LoadLocal(this ILGenerator il, LocalBuilder x) => il.Emit(OpCodes.Ldloc, x);

        // Загружает в стек адрес заданной переменной
        public static void LoadLocalAddress(this ILGenerator il, LocalBuilder x) => il.Emit(OpCodes.Ldloca_S, x);

        // Извлекает из стека значение и присваивает его заданной переменной
        public static void SetLocal(this ILGenerator il, LocalBuilder x) => il.Emit(OpCodes.Stloc, x);

        // Выполняет виртуальный вызов заданного метода
        public static void CallVirt(this ILGenerator il, MethodInfo method) => il.EmitCall(OpCodes.Callvirt, method, null);

        // Выполняет статический вызов заданного метода
        public static void Call(this ILGenerator il, MethodInfo method) => il.EmitCall(OpCodes.Call, method, null);

        // Загружает значение заданного свойства у заданной переменной
        public static void LoadPropertyValue(this ILGenerator il, PropertyInfo property, LocalBuilder target)
        {
            // Если целевая переменная является типом-значением
            if (target.LocalType.IsValueType || target.LocalType.IsNullable())
            {
                // Загружаем в стек адрес переменной
                il.LoadLocalAddress(target);

                // Статически вызываем геттер свойства
                il.Call(property.GetGetMethod());
            }
            // Если целевая переменная является ссылочным типом 
            else
            {
                // Загружаем в стек значение переменной
                il.LoadLocal(target);

                // Виртуально вызываем геттер свойства
                il.CallVirt(property.GetGetMethod());
            }
        }

        // Возвращает новую переменную, содержащую значение заданного свойства у заданной переменной
        public static LocalBuilder GetPropertyValue(this ILGenerator il, PropertyInfo property, LocalBuilder target)
        {
            // Объявляем новую локальную переменную
            var x = il.DeclareLocal(property.PropertyType);

            // Загружаем значение переменной
            il.LoadPropertyValue(property, target);

            // Устанавливаем значение новой локальной переменной
            il.SetLocal(x);
            return x;
        }

        // Загружает в стек длину заданного массива
        public static void LoadArrayLength(this ILGenerator il, LocalBuilder array)
        {
            il.LoadLocal(array);
            il.Emit(OpCodes.Ldlen);
            il.Emit(OpCodes.Conv_I4);
        }

        // Извлекает из стека массив и индекса, а загружает в стек элемент массива с заданным индексом
        public static void LoadArrayElement(this ILGenerator il) => il.Emit(OpCodes.Ldelem_I4);

        // Возвращает новую переменную, содержащую элемент массива с заданным индексом
        public static LocalBuilder GetArrayElement(this ILGenerator il, Type elementType, LocalBuilder array, LocalBuilder index)
        {
            var x = il.DeclareLocal(elementType);
            il.LoadLocal(array);
            il.LoadLocal(index);
            il.LoadArrayElement();
            il.SetLocal(x);
            return x;
        }

        // Увеличивает значение заданной переменной на единицу
        public static void Increment(this ILGenerator il, LocalBuilder x)
        {
            il.LoadLocal(x);
            il.LoadOne();
            il.Emit(OpCodes.Add);
            il.SetLocal(x);
        }
    }
}