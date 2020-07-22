using System;
using static System.Console;

namespace HelloWorldApp
{
    class Program
    {
        // 字段
        private static int j = 20;
        static void Main(string[] args)
        {
            WriteLine("Hello World!");

            #region 变量
            // 声明变量
            /*
            int i;
            i = 1;

            int a = 2;

            int b = 1, c = 2;

            // int t = 1, bool f = true;
            */

            // 类型判断
            /*var a = 1;
            //等同于
            // int a = 1;
            var name = "jonty";
            var age = 18;

            Type nameType = name.GetType();
            WriteLine(nameType);

            Type ageType = age.GetType();
            WriteLine(ageType);

            变量必须初始化，否则编译器就无法推断变量类型
            初始化器不能为空
            初始化器必须放在表达式中
            不能把初始化器设置为一个对象，除非在初始化器中创建了一个新对象
            */

            /*
             * 变量的作用域：可以访问该变量的区域
             * 只要在类的某个作用域内，其字段（成员变量）也在该作用域内
             * 局部变量存在于声明该变量的快语句或方法结束的右花括号之间的作用域内
             * 在for、while或类似语句中申明的局部变量存在于该循环体内
             */

            // 同名变量不能在统一作用域内声明两次
            // int a = 1;
            // int a = 2;


            // 每个变量i对于各自的循环来说是局部变量
            /*for (int i = 0; i < 10; i++)
            {
                WriteLine(i);
            }

            for (int i = 9; i >=0; i--)
            {
                WriteLine(i);
            }*/

            /*
             * 变量j是在for循环开始之前定义的，在执行for循环时仍处于其作用域内，
             * 直到Main（）方法结束执行后，变量j才超出作用域。第2个j （不合法）虽然在循环的作
             * 用域内，但作用域嵌套在Main（）方法的作用域内。因为编译器无法区分这两个变量，
             * 所以不允许声明第二个变量。
             
             int j = 20;
             for (int i = 0; i < 10; i++)
             {
                 int j = 30;
                 WriteLine(j+i);
             }
             */
            #endregion

            // 局部变量
            int j = 30;
            WriteLine(j);// 30
            WriteLine(Program.j);// 20


            /*
             * 常量：不会发生改变的量 const
             * 必须在声明时初始化，指定值之后不能再改写
             * 常量的值必须能在编译时用于计算，不能用从常量中提取的值来初始化常量，应该使用只读字段
             * 常量是隐式静态的，不允许在声明常量时包含修饰符static
             *
             * 好处：
             * 易于读取
             * 易于修改
             * 避免程序出现错误
             */
            const int a = 12; // this value cannot be changed


        }

        static int Show()
        {
            // int q;
            // WriteLine(q);// 方法的局部变量必须显示初始化
            return 0;
        }
    }
}
