using System;
using System.Reflection;

namespace MyAttribute.Extension
{
    /// <summary>
    /// 用户状态
    /// </summary>
    enum UserState
    {
        /// <summary>
        /// 正常
        /// </summary>
        [Remark("正常")]
        Normal=0,
        /// <summary>
        /// 冻结
        /// </summary>
        [Remark("冻结")]
        Frozen=1,
        /// <summary>
        /// 删除
        /// </summary>
        [Remark("删除")]
        Delete=2
    }

    // 枚举加描述 实体类属性也可以Display

    public class RemarkAttribute : Attribute
    {
        private readonly string _remark;

        public RemarkAttribute(string remark)
        {
            _remark = remark;
        }
        public string GetRemark()
        {
            return _remark;
        }
    }
    public static  class RemarkExtension
    {
        /// <summary>
        /// 获取注释
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetRemark(this Enum value)
        {
            // 找到枚举类型
            Type type = value.GetType();

            // 获取字段
            FieldInfo field = type.GetField(value.ToString());


            if (field.IsDefined(typeof(RemarkAttribute),true))
            {
                RemarkAttribute attribute = (RemarkAttribute) field.GetCustomAttribute(typeof(RemarkAttribute), true);

                return attribute.GetRemark();
            }
            else
            {
                return value.ToString();
            }
        }
    }
}