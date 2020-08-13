using System;

namespace Pet
{

    /*
    * 抽象类
    * 1、抽象类只是用来被继承
    * 不能实例化，使用abstract修饰
    * 可以包含抽象成员和普通成员
    * 抽象类的抽象成员在派生类中需要用override实现
    */


    /// <summary>
    /// 宠物父类
    /// </summary>
    public abstract class Pet
    {
        public string _name;

        public Pet(string name)
        {
            _name = name;
        }

        public void PrintName()
        {
            Console.WriteLine($"Pet's name is {_name}");
        }

        /// <summary>
        /// 说话 虚方法
        /// </summary>
        // public virtual void Speak()
        // {
        //     Console.WriteLine("Pet is Speak");
        // }

        // 抽象方法 没有实现
        public abstract void Speak();
    }
}