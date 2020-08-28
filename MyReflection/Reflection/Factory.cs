using System;
using System.Configuration;
using System.Reflection;
using DB.Interface;

namespace Reflection
{
    /// <summary>
    /// 创建对象
    /// </summary>
    public class Factory
    {

        private static string IDBHelper = ConfigurationManager.AppSettings["IDBHelperConfig"];

        private static string DllName = IDBHelper.Split(',')[1];
        private static string TypeName = IDBHelper.Split(',')[0];
        public static IDBHelper CreateHelper()
        {

            // 加载dll
            // Assembly assembly = Assembly.Load("DB.MySQL");
            Assembly assembly = Assembly.Load(DllName);

            // 获取类型信息
            // Type type = assembly.GetType("DB.MySQL.MySQLHelper");
            Type type = assembly.GetType(TypeName);

            // 创建对象
            object oHelper = Activator.CreateInstance(type);

            // 类型转换
            IDBHelper iDbHelper = (IDBHelper)oHelper;

            return iDbHelper;
        }
    }
}