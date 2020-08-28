using System;

namespace DB.SqlServer
{
    public class ReflectionTest
    {
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public ReflectionTest()
        {
            Console.WriteLine($"这是{this.GetType()}无参构造函数");
        }

        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="name"></param>
        public ReflectionTest(string name)
        {
            Console.WriteLine($"这是{this.GetType()}有参构造函数");
        }

        public ReflectionTest(int id)
        {
            Console.WriteLine($"这是{this.GetType()}有参构造函数");
        }

        /// <summary>
        /// 无参方法
        /// </summary>
        public void Show1()
        {
            Console.WriteLine($"这里是{this.GetType()}Show1");
        }

        /// <summary>
        /// 有参方法
        /// </summary>
        /// <param name="id"></param>
        public void Show2(int id)
        {
            Console.WriteLine($"这里是{this.GetType()}Show2");
        }

        /// <summary>
        /// 重载方法
        /// </summary>
        public void Show3()
        {
            Console.WriteLine($"这里是{this.GetType()}Show3_1");

        }

        public void Show3(int id, string name)
        {
            Console.WriteLine($"这里是{this.GetType()}Show3_2");
        }

        public void Show3(string name, int id)
        {
            Console.WriteLine($"这里是{this.GetType()}Show3_3");
        }

        public void Show3(string name)
        {
            Console.WriteLine($"这里是{this.GetType()}Show3_4");
        }

        public void Show3(int id)
        {
            Console.WriteLine($"这里是{this.GetType()}Show3_5");

        }


        /// <summary>
        /// 私有方法
        /// </summary>
        /// <param name="name"></param>
        private void Show4(string name)
        {
            Console.WriteLine($"这里是{this.GetType()}Show4:{name}");
        }

        public static void Show5(string name)
        {
            Console.WriteLine($"这里是{typeof(ReflectionTest)}Show5");
        }
    }
}