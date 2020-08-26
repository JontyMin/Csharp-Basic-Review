using System;

namespace Pet
{
    /*
     * 如果类只包含静态的方法和属性，并且标识为static
     * 静态类不能创建实例，不能被继承
     * 可以为静态类定义一个静态构造函数
     * 主要用于基础类库和扩展方法
     *
     * 扩展方法
     */
    public class Cat : Pet,ICatchMice,IClimbTree
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="Name"></param>
        public Cat(string name):base(name)
        {
        }
        public override void Speak()
        {
            // base.Speak();
            Console.WriteLine($"{_name} is speaking : mmm");
        }

        public void CatchMice()
        {
            Console.WriteLine($"{_name} Catch mice");
        }

        public void ClimbTree()
        {
            Console.WriteLine($"{_name} Climb Tree");
        }

        /// <summary>
        /// 显示转换
        /// </summary>
        /// <param name="cat"></param>
        public static explicit operator Dog(Cat cat)
        {
            return new Dog(cat._name);
        }
    }
}