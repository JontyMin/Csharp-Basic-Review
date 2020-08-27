using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace Generic.Extend
{
    public class GenericCacheTest
    {
        public static void Show()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(GenericCache<int>.GetCache());
                Thread.Sleep(10);
                Console.WriteLine(GenericCache<long>.GetCache());
                Thread.Sleep(10);
                Console.WriteLine(GenericCache<string>.GetCache());
                Thread.Sleep(10);

            }
        }
    }

    public class DictionaryCache
    {
        private static Dictionary<Type, string> _typeTimeDictionary = null;

        static DictionaryCache()
        {
            Console.WriteLine("This is DictionaryCache 静态构造函数");
            _typeTimeDictionary=new Dictionary<Type, string>();
        }

        public static string GetCache<T>()
        {
            Type type = typeof(Type);
            if (!_typeTimeDictionary.ContainsKey(type))
            {
                _typeTimeDictionary[type] = $"{typeof(T).FullName}_{DateTime.Now}";
            }

            return _typeTimeDictionary[type];
        }
    }

    /// <summary>
    /// 每个不同的T,都会生成不同的副本
    /// 适合不同的类型，需要缓存一份数据的场景、效率高
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericCache<T>
    {
        static GenericCache()
        {
            Console.WriteLine("This is GenericCache静态构造函数");
            _TypeTime = $"{typeof(T).FullName}_{DateTime.Now}";
        }

        private static string _TypeTime = "";

        public static string GetCache()
        {
            return _TypeTime;
        }
    }
}