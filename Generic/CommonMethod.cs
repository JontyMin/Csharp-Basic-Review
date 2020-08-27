using System;
using System.Xml.Serialization;

namespace Generic
{
    public class CommonMethod
    {
        /// <summary>
        /// 打印Int的值
        /// </summary>
        /// <param name="iParameter"></param>
        public static void ShowInt(int iParameter)
        {
            Console.WriteLine($"This is {typeof(CommonMethod)},parameter={iParameter.GetType().Name},type={iParameter}");
        }

        /// <summary>
        /// 打印string的值
        /// </summary>
        /// <param name="iParameter"></param>
        public static void ShowString(string sParameter)
        {
            Console.WriteLine($"This is {typeof(CommonMethod)},parameter={sParameter.GetType().Name},type={sParameter}");
        }

        /// <summary>
        /// 打印DateTime的值
        /// </summary>
        /// <param name="iParameter"></param>
        public static void ShowDateTime(DateTime dParameter)
        {
            Console.WriteLine($"This is {typeof(CommonMethod)},parameter={dParameter.GetType().Name},type={dParameter}");
        }

        /// <summary>
        /// 打印object的值
        /// 1、object是一切类型的基类
        /// 2、通过继承，子类拥有父类的一切属性和行为；任何父类出现的地方，都可以用子类代替
        ///
        /// .NET Framework 1.0
        /// object 引用类型，传值类型会有装箱的操作
        /// </summary>
        /// <param name="oParameter"></param>
        public static void ShowObject(object oParameter)
        {
            Console.WriteLine($"This is {typeof(CommonMethod)},parameter={oParameter.GetType().Name},type={oParameter}");
        }
    }
}