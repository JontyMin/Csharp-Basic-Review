using System;
using System.Runtime.InteropServices;

namespace Generic
{
    public interface ISport
    {
        void Pingpang();
    }

    public interface IWork
    {
        void Work();
    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Hi()
        {
            Console.WriteLine("Hi");
        }
    }

    public class Chinese : People, ISport, IWork
    {
        public void Tradition()
        {
            Console.WriteLine("仁义礼智信，温良恭谦让");
        }

        public void SayHi()
        {
            Console.WriteLine("你吃了吗");
        }

        public void Pingpang()
        {
            Console.WriteLine("打乒乓去球");
        }

        public void Work()
        {
            Console.WriteLine("工作");
        }
    }

    public class HuNan : Chinese
    {
        public string CS { get; set; }

        public void Chou()
        {
            Console.WriteLine("吃臭豆腐");
        }
    }

    public class Japanese:ISport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Pingpang()
        {
            Console.WriteLine("打乒乓球");
        }
    }
}