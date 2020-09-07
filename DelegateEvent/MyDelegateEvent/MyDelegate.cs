namespace MyDelegateEvent
{
    public class MyDelegate
    {
        /// <summary>
        /// 无参数无返回值
        /// </summary>
        public delegate void NoReturnNoPara();

        /// <summary>
        /// 有参数无返回值
        /// </summary>
        public delegate void NoReturnWithPara(int x,int y);

        public delegate int WithReturnNoPara();

        public delegate string WithReturnWithPara(out int x, ref int y);
    }
}