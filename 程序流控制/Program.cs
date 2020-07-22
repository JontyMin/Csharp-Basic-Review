using System;
using static System.Console;

namespace 程序流控制
{
    class Program
    {
        static void Main(string[] args)
        {
            // 条件语句

            // 执行一条语句时可以不要花括号
            /*if (1 > 0)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
            
            WriteLine("Type in a string");
            string input;
            input = ReadLine();
            if (input == "")
            {
                WriteLine("You typed in an empty string.");
            }
            else if (input.Length < 5)
            {
                WriteLine("The string had less than 5 characters.");
            }
            else if (input.Length < 10)
            {
                WriteLine("The string had at least 5 but less than 10 Characters.");
            }
            WriteLine("The string was " + input);
            */

            /*
             * 添加到if子句中的else if语句个数不受限制
             * 对于if如果条件分支中只有一条语句，就无需使用花括号
             * 但是，如果在if语句中不使用花括号，可能在维护代码时出现错误
             * 通常都使用花括号
             * if子句中的表达式必须是boolean型
             */

            /*
             * switch语句
             * switch...case语句适合于从一组互斥的可执行分支中选择一个执行分支
             *
             */

            /*var rd = new Random();
            int a = rd.Next(3);
            switch (a)
            {
                case 0:
                    Console.WriteLine("C#");
                    break;
                case 1:
                    Console.WriteLine("java");
                    break;
                case 2:
                    Console.WriteLine("go");
                    break;
            }
            */

            /*
             * case值必须是常量表达式，不允许为变量
             * case子句的顺序无关紧要
             */

            /*
             * 循环
             * C#提供了4种循环机制
             */

            // for
            for (int i = 0; i < 100; i++)
            {
                if (i%2==0)
                {
                    // 偶数打印
                    Console.WriteLine("i love C#");
                }
                
            }

            // 嵌套
            for (int i = 0; i < 100; i+=10)
            {
                for (int j = i; j < i+10; j++)
                {
                    Write($" {j}");
                }
                WriteLine();
            }
            

            /*
             * while循环 不确定次数循环
             */
            bool flag = false;
            /*while (!flag)
            {
                Console.WriteLine("what i can do");
            }*/

            /*
             * do...while
             * 适用于循环体至少执行一次的情况
             */
            /*do
            {
                WriteLine("i want to go home");
            } while (1>0);*/


            /*
             * foreach 循环 可以迭代集合中的每一项
             */

            int[] arr = {1, 2, 3, 4};
            foreach (var i in arr)
            {
                WriteLine(i);
            }

            /*
             * 循环跳转
             *  goto 一般不使用
             *  break 退出循环
             *  continue 退出循环的当前迭代，进入下一次迭代
             *  return 退出方法，返回值
             */
        }
    }

}
