using System;

namespace Pet
{
    /// <summary>
    ///  狗类 继承自父类Pet
    /// </summary>
    public class Dog : Pet
    {
        public Dog(string name):base(name)
        {
           
        }

        // 隐藏方法 在派生类中声明新的带有相同函数名的成员
        public new void PrintName()
        {
            Console.WriteLine($"宠物的名称是{_name}");
        }

        /// <summary>
        /// 重写虚方法
        /// </summary>
        public sealed override void Speak()
        {
            // sealed 不能再被重写

            //base.Speak();
            Console.WriteLine($"{_name} is speaking : www");
        }
    }
}