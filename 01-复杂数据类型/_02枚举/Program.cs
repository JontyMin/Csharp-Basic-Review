using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02枚举
{
    class Program
    {
        /// <summary>
        /// 声明枚举 Gender
        /// </summary>
        public enum Gender
        {
            男,
            女
        }
        static void Main(string[] args)
        {
            /*
             * 枚举就是一个变量类型
             * 只是枚举的声明、赋值、使用的方式跟普通的变量不一样
             */

            Gender gender = Gender.男;

            // 季节
            Sesons sesons = Sesons.春;


            // 枚举之间的转换
            /*
             * 枚举类型默认可以跟int类型互相转换
             * 枚举类型跟int类型是兼容的
             */
            
            // 枚举——>int
            int n = (int) sesons;
            Console.WriteLine(n);

            // int——>枚举
            Sesons s = (Sesons) 1;
            Console.WriteLine(s);

            //枚举类型转字符串类型
            /*所以类型都能转换成string类型
            int a = 10;
            double a = 3.14;
            decimal a = 500;
            string str = a.ToString();
            */
            string b = sesons.ToString();

            string q = "0";
            // 将q转换成枚举类型
            // 调用Parse()方法的目的是为了让它帮我们将一个字符串转换成对应的枚举类型
            Sesons ons = (Sesons) Enum.Parse(typeof(Sesons), q);
            Console.WriteLine(ons);


            /*
             * 枚举练习
             * 提示用户选择一个季节，我们接受并将 用户的输入转换成枚举类型
             */

            Console.WriteLine("请选择季节 1-春 2-夏 3-秋 4-冬");
            string input = Console.ReadLine();
            Sesons s1 = (Sesons) Enum.Parse(typeof(Sesons), input);
            Console.WriteLine($"你选择季节是{s1}");
                   
            }



        }
    }
}
