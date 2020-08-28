using System;

namespace DB.SqlServer
{
    /// <summary>
    /// 单例模式 程序中只有一个实例
    /// </summary>
    public sealed class Singleton
    {
        /// <summary>
        /// 静态实例 内存中只有一个
        /// </summary>
        private static Singleton _Singleton = null;

        /// <summary>
        /// 构造函数私有化
        /// </summary>
        private Singleton()
        {
            Console.WriteLine("Singleton被构造");
        }

        /// <summary>
        /// 静态构造函数赋值
        /// </summary>
        static Singleton()
        {
            _Singleton=new Singleton();
        }
        /// <summary>
        /// 获取实例
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            return _Singleton;
        }

    }
}