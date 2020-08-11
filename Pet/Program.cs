using System;

namespace Pet
{
    /*
     * Object是所有类的共同基类
     * 它是唯一的非派生类
     * 是继承层次的基础
     *
     * 单一继承
     */

    /// <summary>
    /// 宠物父类
    /// </summary>
    public class Pet
    {
        public string name;

        public void PrintName()
        {
            Console.WriteLine($"Pet's name is {name}");
        }
    }

    /// <summary>
    ///  狗类 继承自父类Pet
    /// </summary>
    public class Dog : Pet
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.name = "jack";
            dog.PrintName();
        }
    }
}
