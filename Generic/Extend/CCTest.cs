using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic.Extend
{
    /// <summary>
    /// .NET 4.0
    /// 只能放在接口或者委托的泛型参数里面
    /// out 协变covariant 修饰返回值
    /// in 逆变contravariant 修饰传入的参数
    /// 参考：https://www.cnblogs.com/wangbaicheng1477865665/p/OutIn.html
    /// </summary>
    public class CCTest
    {
        public static void Show()
        {
            {
                Bird b1 = new Bird();
                Bird b2 = new Sparrow();
                Sparrow b3 = new Sparrow();
                // Sparrow b4 = new Bird();
            }
            {
                List<Bird> birds = new List<Bird>();
                // List<Bird>birds1 = new List<Sparrow>();

                List<Bird> birds2 = new List<Sparrow>()
                    .Select(c=>((Bird)c)).ToList();
            }
            {
                // 协变
                IEnumerable<Bird>birds = new List<Bird>();
                IEnumerable<Bird>birds1=new List<Sparrow>();
                Func<Bird> func = new Func<Sparrow>(() => null);


                ICustomerListOut<Bird> customerList1 = new CustomerListOut<Bird>();//这是能编译的
                ICustomerListOut<Bird> customerList2 = new CustomerListOut<Sparrow>();//这也是能编译的，在泛型中，子类指向父类，我们称为协变
            }

            {
                // 逆变
                ICustomerListIn<Sparrow> customerList2 = new CustomerListIn<Sparrow>();
                ICustomerListIn<Sparrow> customerList1 = new CustomerListIn<Bird>();//父类指向子类，我们称为逆变

                ICustomerListIn<Bird> birdList1 = new CustomerListIn<Bird>();
                birdList1.Show(new Sparrow());
                birdList1.Show(new Bird());

                Action<Sparrow> act = new Action<Bird>((Bird i) => { });
            }
        }

    }

    /// <summary>
    /// 逆变
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICustomerListIn<in T>
    {
        //T Get();//不能作为返回值

        void Show(T t);
    }

    public class CustomerListIn<T> : ICustomerListIn<T>
    {
        public T Get()
        {
            return default(T);
        }

        public void Show(T t)
        {
        }
    }


    /// <summary>
    /// out 协变 只能是返回结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICustomerListOut<out T>
    {
        T Get();

        // void Show(T t);//T不能作为传入参数
    }

    /// <summary>
    /// 类没有协变逆变
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CustomerListOut<T> : ICustomerListOut<T>
    {
        public T Get()
        {
            return default(T);
        }

        public void Show(T t)
        {

        }
    }
    /// <summary>
    /// 鸟类
    /// </summary>
    public class Bird
    {
        public int Id { get; set; }

    }
    /// <summary>
    /// 麻雀
    /// </summary>
    public class Sparrow : Bird
    {
        public string Name { get; set; }

    }
}