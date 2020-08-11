namespace OOPDemo
{
    /// <summary>
    /// 声明接口的语法和声明抽象类完全相同
    /// 但不允许提供接口中任何成员的执行方法
    /// 实现接口的类必须实现接口中的所有方法和属性
    /// </summary>
    public interface ICal
    {
        string GetAreaAlgorithm();
    }
}