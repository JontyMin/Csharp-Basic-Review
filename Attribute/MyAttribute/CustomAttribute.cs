using System;

namespace MyAttribute
{
    /// <summary>
    /// 特性：一个类，直接或简介继承Attribute
    /// 一般以Attribute结尾，声明时可以省略
    /// </summary>
    /// AttributeTargets修饰约定，
    [AttributeUsage(AttributeTargets.All,AllowMultiple = true,Inherited = true)]
    public class CustomAttribute:Attribute
    {
        public CustomAttribute()
        {
            
        }

        public CustomAttribute(int id)
        {
            
        }

        public string Description { get; set; }

        public string Remark = null;
    }
}