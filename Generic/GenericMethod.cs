using System;

namespace Generic
{
    public class GenericMethod
    {
        /// <summary>
        /// 泛型方法
        /// 2.0推出的新语法
        /// 延迟声明：把参数类型的声明推迟到调用
        /// 泛型方法解决用一个方法，满足不同参数类型实现相同的操作
        /// 推迟一切可以推迟的 延迟思想
        /// </summary>
        /// <typeparam name="T">不要用关键字，也不要和别的类冲突</typeparam>
        /// <param name="tParameter"></param>
        public static void Show<T>(T tParameter)
        {
            Console.WriteLine($"This is {typeof(CommonMethod)},parameter={tParameter.GetType().Name},type={tParameter}");

        }
    }
}