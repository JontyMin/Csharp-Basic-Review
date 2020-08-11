namespace OOPDemo
{
    /// <summary>
    /// 子类
    /// </summary>
    public class Rectangle : Shape,ICal
    {
        /*
         * 子类拥有父类非private的属性和功能
         * 子类拥有父类的属性Name,GetName()方法
         * 构造方法不能被继承，只能被调用(使用base)
         */
        public Rectangle(string name) : base(name)
        {
        }

        
        /// <summary>
        /// 子类可以用自己的方式实现父类的方法，重写
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return "子类的图形名：" + Name;
        }


        /*
         * 子类具有自己的属性和方法，即子类可以扩展父类没有的属性和功能
         * 
         */

        /// <summary>
        /// 长度
        /// </summary>
        public double Length { get; set; }
        /// <summary>
        /// 宽度
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// 获取面积
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return  Length * Width;
        }


        

        public string GetAreaAlgorithm()
        {
            return "矩形面积算法：长×宽";
        }

        public delegate int CalculatorAdd(int x, int y);

        public static int add(int x, int y)
        {
            return x * y;
        }
    }
}