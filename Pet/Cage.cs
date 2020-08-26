using System;

namespace Pet
{
    /*
     * 优势：
     * 代码量小
     * 只有需要的类型才会实例化
     * 易于维护
     */

    /// <summary>
    /// 泛型类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Cage<T>
    {
        private T[] array;
        private readonly int Size;
        private int num;

        public Cage(int n)
        {
            Size = n;
            num = 0;
            array=new T[Size];
        }

        public void Putin(T pet)
        {
            if (num<Size)
            {
                array[num++] = pet;
            }
            else
            {
                Console.WriteLine("cage is full");
            }
        }

        public T TakeOut()
        {
            if (num>0)
            {
                return array[--num];
            }
            else
            {
                Console.WriteLine("cage is full");
                return default(T);
            }
        }
    }
}