using System;

namespace Generic
{
    public class Constraint
    {
        /// <summary>
        /// 泛型：不同的参数类型都能进来；任何类型都能进来，你知道我是谁？
        /// 没有约束就没有自由
        /// 泛型约束：基类约束(不能是sealed密封类)
        /// where T:class,interface
        /// 1、可以使用基类的一切属性方法--权力
        /// 2、强制保证T一定是People或其子类--义务
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tParameter"></param>
        public static void Show<T>(T tParameter)
        where T:People
        {
            //Console.WriteLine($"This is {typeof(CommonMethod)},parameter={tParameter.GetType().Name},type={tParameter}");
            Console.WriteLine($"{tParameter.Id}_{tParameter.Name}");
            tParameter.Hi();
            
        }

        public static T Get<T>(T t)
            // where T:ISport //接口约束
            // where T : class //引用类型约束
            // where T : struct//值类型约束
            where T:new() //无参数构造函数约束
        {
            // t.Pingpang();
            // T tnew = null;
            // T tnew = default(T);//会根据T的类型赋予默认值
            T tNew = new T();
            return t;
        }
    }
}