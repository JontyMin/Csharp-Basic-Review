using System.Runtime.CompilerServices;

namespace Pet
{
    /*
     * Object是所有类的共同基类
     * 它是唯一的非派生类
     * 是继承层次的基础
     *
     * 单一继承
     */

    /*
     * 结构是值类型 => 栈  类是引用类型 =>堆
     * 结构不支持继承 类支持继承
     * 结构不能定义默认构造函数 编译器会定义
     */

    /*struct filh
    {
        private int weight;
        private int size;
        private int type;
    }*/

   /// <summary>
   /// 抽象类
   /// </summary>
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

            /*
            Pet[] pets = new Pet[]
            {
                new Cat("Jack"),
                new Cat("Hao"), 
                new Dog("Jack"),
                new Dog("Tom"), 
                new Labrador("heirui"), 

            };

            foreach (var pet in pets)
            {
                pet.Speak();
            }

            Cat c = new Cat("Tomm");
            // 通过对象调用
            c.CatchMice();
            c.ClimbTree();

            // 接口调用
            ICatchMice catchMice = (ICatchMice) c;
            catchMice.CatchMice();

            IClimbTree climbTree = (IClimbTree) c;
            climbTree.ClimbTree();
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

            /*
             * 密闭方法
             * 如果一个基类方法不希望子类对其重写
             * 就可以不声明为virtual
             * 如果是某个派生类方法不希望子类对其重写
             * 同时是override重写，就可以使用sealed机制
             */

            /*
            Dog.ShowNum();

            Dog dog = new Dog("Tommy");

            // Dog类的扩展方法
            dog.HowToFeedDog();


            {

                // 装箱 => 值类型转换成引用类型 堆  隐式转换
                // 装箱的本质就是在堆上创建了引用类型，新创建的引用类型和原来的值类型相互独立
                int i = 3;
                object oi = i;
                Console.WriteLine($"i={i},oi={oi}");

                oi = 10;
                i = 7;
                Console.WriteLine($"i={i},oi={oi}");

                // 拆箱 => 将拆箱后的对象转换回值类型的过程 显示转换

                int j = (int)oi;

                Console.WriteLine($"j={j},oi={oi}");

            }

            /*
             * 自定义转换 => 为结构和类定义显示和隐式转换
             * 
             *
             */
            /*
            Dog d = new Dog("ktg");
            d.Speak();

            // 隐式换成猫
            Cat cc = d;
            cc.Speak();

            Dog dd = (Dog) cc;
            dd.Speak();
            */

            var dogCage = new Cage<Dog>(3);
            dogCage.Putin(new Dog("java"));
            dogCage.Putin(new Dog("go"));
            dogCage.Putin(new Labrador("python"));

            var dog = dogCage.TakeOut();
            dog.PrintName();

            var d = new Dog("has");
            d.isHappy<Cat>(new Cat("kaf"));

        }

        
    }
}
