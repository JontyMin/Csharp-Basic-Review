using System;

namespace OOPDemo
{
    class Program
    {
        /*
         * 面向对象三大特性：封装、继承、多态
         * 每个对象都包含它能进行操作的所有信息(不必依赖其他对象),这个特性称为封装
         * 封装降低了耦合，类内部的实现可以自由的修改，使类具有清晰的对外接口
         *
         * 对象的继承代表了一种"一般到特殊"的关系，例如 学生 是一种人类
         * 继承定义了类如何相互关联、共享特性
         * 定义父类和子类，也叫基类和派生类
         *
         * 多态：表示不同的对象可以执行相同的动作，但要通过它们自己的代码执行
         *
         * 总结：
         * 类是对对象的抽象，抽象类是对类的抽象，接口是对行为的抽象
         * 如果行为跨越不同对象，可使用接口
         * 从设计角度来看，抽象类是从子类中发现公共的东西，泛化出父类
         * 而接口根本不知道子类的存在，方法如何实现还不确定，预先定义
         *
         * 抽象类往往都是通过重构的来的，抽象类是自底向上抽象出来的，而接口是自顶向下设计出来的
         */
        static void Main(string[] args)
        {
            /*
             * 对象的声明是父类，实例化的是子类
             * 子类以父类身份出现时，子类特有的属性和方法不可使用
             *
             */
            Shape s = new Rectangle("正方形");

            // 覆写父类方法
            Console.WriteLine(s.GetName()); // 子类的图形名：正方形


            Rectangle r = new Rectangle("长方形")
            {
                Width = 12,
                Length = 3
            };

            Console.WriteLine(r.GetName()+"的面积是："+r.GetArea());

            // 接口
            ICal cal=new Rectangle("正方形a");

            Console.WriteLine(cal.GetAreaAlgorithm());

            CalculatorAdd cadd = new CalculatorAdd(add);

            int result = cadd.Invoke(3, 4);
            //todo:测试任务列表
        }

        public delegate int CalculatorAdd(int x, int y);

        public static int add(int x, int y)
        {
            return x * y;
        }

    }
}
