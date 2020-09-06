using System;
using System.Reflection;

namespace MyAttribute.Extension
{
    public static class ValidateExtension
    {
        public static bool Validate(this object oObject)
        {
            Type type = oObject.GetType();
            foreach (var prop in type.GetProperties())
            {
                if (prop.IsDefined(typeof(LongAttribute),true))
                {
                    LongAttribute attribute = (LongAttribute) prop.GetCustomAttribute(typeof(LongAttribute), true);

                    if (!attribute.Validate(prop.GetValue(oObject)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }

    /// <summary>
    /// long长度验证
    /// </summary>
    public class LongAttribute : Attribute
    {
        private long _Min = 0;
        private long _Max = 0;
        public LongAttribute(long min,long max)
        {
            _Min = min;
            _Max = max;
        }

        public bool Validate(object value)
        {
            if (value!=null&&!string.IsNullOrWhiteSpace(value.ToString()))
            {
                if (long.TryParse(value.ToString(),out long lResult))
                {
                    if (lResult>_Min&&lResult<_Max)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}