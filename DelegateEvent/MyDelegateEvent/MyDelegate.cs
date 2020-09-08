using System;

namespace MyDelegateEvent
{
    /// <summary>
    /// 委托：是一个类，继承自System.MulticastDelegate
    /// </summary>
    public delegate void NoReturnNoParaOutClass();

    public class MyDelegate
    {
        /// <summary>
        /// 无参数无返回值
        /// </summary>
        public delegate void NoReturnNoPara();

        /// <summary>
        /// 有参数无返回值
        /// </summary>
        public delegate void NoReturnWithPara(int x,int y);

        /// <summary>
        /// 无参数有返回值
        /// </summary>
        /// <returns></returns>
        public delegate int WithReturnNoPara();
        
        /// <summary>
        /// 有参有返回
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public delegate string WithReturnWithPara(out int x, ref int y);


        public void Show()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "Jonty",
                Age = 18,
                ClassId = 1
            };
            student.Study();

            {
                // 把方法包装成变量 invoke时执行方法
                NoReturnNoPara methodNoPara=new NoReturnNoPara(this.DoNothing);

                // Invoke方法 委托里的方法 委托实例的调用
                methodNoPara.Invoke();
                // 等同于
                methodNoPara();

                // 执行
                this.DoNothing();
            }

        }

        private void DoNothing()
        {
            Console.WriteLine("This is DoNothing");
        }

        private static void DoNothingStatic()
        {
            Console.WriteLine("This is DoNothingStatic");
        }
    }
}