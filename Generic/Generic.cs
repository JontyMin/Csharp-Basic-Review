namespace Generic
{
    /// <summary>
    /// 一个类来满足不同的具体类型，做相同的事
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Generic<T>
    {
        public T _t;
    }

    /// <summary>
    /// 泛型接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericInterface<T>
    {
        T GetT(T t);// 泛型类型的返回值
    }


    /// <summary>
    /// 泛型在使用的时候必须指定类型
    /// </summary>
    public class CommonClass : IGenericInterface<int>
    {
        public int GetT(int t) => throw new System.NotImplementedException();
    }

    public class GenericClassChild<T> : Generic<T>,IGenericInterface<int>
    {
        public int GetT(int t) => throw new System.NotImplementedException();
    }

    /// <summary>
    /// 泛型委托
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="t"></param>
    public delegate void SayHi<T>(T t);//泛型委托

}