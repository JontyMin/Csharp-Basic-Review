using System;
using static System.Console;
namespace 枚举
{

    public enum TimeOfDay
    {
        /// <summary>
        /// 上午
        /// </summary>
        Morning=0,
        /// <summary>
        /// 中午
        /// </summary>
        Afternoon=1,
        /// <summary>
        /// 下午
        /// </summary>
        Evening=2
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 枚举是用户定义的整数类型
             * 枚举可以使代码更易维护，有助于确保变量指定合法的、期望的值
             * 使代码更清晰，允许用描述性的名称表示整数值，而不是用含义模糊、变化多端的值表示
             * 使代码更易输入
             */
#if false
            
            WriteLine(TimeOfDay.Morning);
#endif

            /*
             * 枚举在后台会实例化为派生自基类System.Enum的机构
             * 可以对它们调用方法，执行有用的任务
             * 由于Framework的实现方式，在语法上把枚举当成结构不会造成性能损失
             * 编译完成之后就和基本类型 int float类似
             */

            // 检索枚举的字符串表示
            TimeOfDay time = TimeOfDay.Evening;
            WriteLine(time);

            // 字符串获取枚举值
            // 第1个参数是要使用的枚举类
            // 第2个参数是要转换的字符串
            // 第3个参数是一个bool，指定在进行转换时是否忽略大小写
            TimeOfDay time2 = (TimeOfDay) Enum.Parse(typeof(TimeOfDay), "afternoon", true);
            WriteLine(time2);


        }
    }
}
