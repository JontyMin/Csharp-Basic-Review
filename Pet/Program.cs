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
        public override void Speak()
        {
            //base.Speak();
            Console.WriteLine($"{_name} is speaking : www");
        }
    }

    public class Cat : Pet
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
    }

    /*
     * 抽象类
     * 1、抽象类只是用来被继承
     * 不能实例化，使用abstract修饰
     * 可以包含抽象成员和普通成员
     * 抽象类的抽象成员在派生类中需要用override实现
     */
    abstract class A
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            // 不能被实例化
            // A a = new A();

            // 使用基类调用 则使用基类的方法
            // 通过基类引用指向派生类，仅能访问到派生类中的基类部分
            /*
            Pet dog = new Dog { name = "Jack" };
            dog.PrintName();
            dog.Speak();

            Pet cat = new Cat {name = "mary"};
            cat.PrintName();
            cat.Speak();
            */

            Pet[] pets = new Pet[]
            {
                new Cat("Jack"),
                new Cat("Hao"), 
                new Dog("Jack"),
                new Dog("Tom"), 

            };

            foreach (var pet in pets)
            {
                pet.Speak();
            }

            /*
             * 虚方法和多态
             * 虚方法：声明为virtual的方法就是虚方法
             * 重写：派生类使用override对虚方法进行重写
             * 多态：通过指向派生类的基类引用，调用虚函数，
             * 会根据应用所指向派生类的实际类型，调用派生类中的同名重写函数，便是多态
             *
             * 重写虚方法必须具有相同的可访问性，且基类方法不能是private
             * 不能重写static方法或非虚方法
             * 方法、属性、索引器、事件等都可以声明为virtual或override
             */
        }
    }
}
