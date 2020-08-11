namespace OOPDemo
{
    /// <summary>
    /// 图形类
    /// </summary>
    public abstract class Shape
    {
        /*
         * 抽象类通常代表一个抽象概念
         * 提供一个继承的出发点，当设计一个抽象类时，一定是用来继承的
         * 把没有任何意义的父类改成抽象类，让抽象类拥有尽可能多的共同代码，拥有尽可能少的数据
         */
        public string Name { get; set; }

        public Shape(string name)
        {
            this.Name = name;
        }


        /*public virtual string GetName()
        {
            return "父类的图形名：" + Name;
        }*/
        /*
         * 把Shape改成抽象类 abstract
         * GetName删除方法体，改成抽象方法
         * 1、抽象类不能实例化
         * 2、抽象方法是必须被子类重写的方法(没有实现体的虚方法)
         * 3、如果类中包含抽象方法，类必须被定义成抽象类
         */
        public abstract string GetName();
    }
}