using System;

namespace Pet
{
    public class Cat : Pet,ICatchMice,IClimbTree
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

        public void CatchMice()
        {
            Console.WriteLine($"{_name} Catch mice");
        }

        public void ClimbTree()
        {
            Console.WriteLine($"{_name} Climb Tree");
        }
    }
}