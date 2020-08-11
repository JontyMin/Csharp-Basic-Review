using System;

namespace Pet
{
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

        public abstract void Speak();
    }
}