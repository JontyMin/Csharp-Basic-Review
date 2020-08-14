using System;

namespace Pet
{

    /*
     * 静态成员
     * 标记为static的字段、方法、属性、构造函数、事件是静态成员
     * 静态成员将被类的所有实例共享、所有实例都访问同一内存地址
     * 静态成员和实例成员分开保存
     * 静态成员通过类直接访问，独立于任何实例，没有实例也可以访问，其初始化语句在静态成员使用之前调用
     *
     * 静态函数不能访问实例成员，仅能访问其他静态成员
     *
     * 静态构造函数
     * 用于初始化静态字段
     * 在引用任何静态成员之前，和创建任何实例之前调用
     * 与类同名，使用static,无参数，无访问修饰符
     */

    /// <summary>
    ///  狗类 继承自父类Pet
    /// </summary>
    public class Dog : Pet
    {
        // 静态成员
        private static int num;

        // 静态构造函数
        static Dog()
        {
            num = 0;
        }

        public static void ShowNum()
        {
            Console.WriteLine($"Dog's number {num}");
        }

        public Dog(string name):base(name)
        {
            num++;
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

    /// <summary>
    /// 静态类 扩展方法
    /// </summary>
    static class PetGuide
    {
        public static void HowToFeedDog(this Dog dog)
        {
            Console.WriteLine("How to feed a Dog");
        }
    }
}