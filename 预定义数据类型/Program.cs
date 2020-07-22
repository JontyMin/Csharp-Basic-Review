using System;
using System.Numerics;

namespace 预定义数据类型
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * C#数据类型 
             * 1、值类型——存储在堆栈(stack)
             * 2、引用类型——存储在托管堆(managed heap)
             */
            
            // 在内存中开辟两块空间
            int i = 20;
            int j = i;

            /*
             * 内置值类型表示基本类型：整形、浮点型、字符型、布尔型
             * int:
             *      sbyte,short,int,long,byte,ushort,uint,ulong
             * 浮点型:
             *      float:单精度浮点 32位
             *      double:双精度浮点 64位
             *      decimal: 高精度十进制表示法 128位 不是基本类型，会有性能损耗
             * bool型：
             *      bool:true \ false
             * 字符型：
             *      char:字符
             */
            decimal d = 12.30M;

            char a = '\'';
            Console.WriteLine(a);

            /*
             * C#支持两种预定义的引用类型
             * object:根类型
             * string:Unicode字符串
             *
             */

            // string是一个引用类型，被分配在堆上，因此，当把一个字符串变量复制给另一个字符串时
            // 会得到对内存中同一个字符的两个引用
            string str1 = "hello";
            string str2 = "world";
            string str3 = str1 + str2;


            /*
             * 改变s1的值对s2没有影响
             * 初始化s1时，在堆上分配了一个新的string对象
             * 初始化s2时，引用也指向了这个对象
             * 当s1的值改变是，并不会替换原来的值
             * 在堆上会为新值重新分配一个对象，s2仍指向原来的对象
             */
            string s1 = "a string";
            string s2 = s1;
            Console.WriteLine($"s1 is {s1}");
            Console.WriteLine($"s2 is {s2}");
            s1 = "jonty";
            Console.WriteLine($"s1 is {s1}");
            Console.WriteLine($"s2 is {s2}");

            // 转义序列以一个反斜杠开头，所以不能在字符串中使用没有经过转义的反斜杠字符
            // string filepath = "d:\\c#\\demo.cs";
            string filepath = @"d:\c#\demo.cs";



        }
    }
}
