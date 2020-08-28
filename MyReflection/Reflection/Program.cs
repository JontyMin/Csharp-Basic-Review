using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DB.Interface;
using DB.MySQL;
using DB.SqlServer;

namespace Reflection
{
    /// <summary>
    /// 反射：System.Reflection .Net框架类库，可以读取并使用metadata
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                {
                    Console.WriteLine("*********common************");
                    IDBHelper iDbHelper = new MySQLHelper();
                    iDbHelper.Query();
                }

                {
                    Console.WriteLine("*************Reflection*************");
                    // 加载dll需要依赖项

                    // dll 从当前目录加载 无后缀
                    Assembly assembly = Assembly.Load("DB.MySQL");

                    // 完整路径的加载
                    Assembly assembly1 = Assembly.LoadFile(@"E:\KeepLearn\C#\Basic-Review\MyReflection\DB.MySQL\bin\Debug\DB.MySQL.dll");

                    // 有后缀或者完整路径
                    Assembly assembly2 = Assembly.LoadFrom("DB.MySQL.dll");

                    // 获取模块信息
                    foreach (var item in assembly.GetModules())
                    {
                        Console.WriteLine(item.FullyQualifiedName);
                    }

                    // 获取类型信息
                    foreach (var item in assembly.GetTypes())
                    {
                        Console.WriteLine(item.FullName);
                    }
                    //GetTypes 获取全部
                    //GetType 获取类型

                    Type type = assembly.GetType("DB.MySQL.MySQLHelper");

                    // 创建对象
                    object oHelper = Activator.CreateInstance(type);
                    //oHelper.Query();// object不能调用，实际上有方法，编译器不通过

                    // 类型转换
                    IDBHelper iDbHelper = (IDBHelper) oHelper;
                    iDbHelper.Query();
                }

                {
                    Console.WriteLine("***************ReflectionFactory**********");
                    IDBHelper iDbHelper = Factory.CreateHelper();

                    // 可配置可扩展 反射是动态的 IOC
                    iDbHelper.Query();

                }

                {
                    Console.WriteLine("****************Reflection+object*************");
                    Singleton singleton1 = Singleton.GetInstance();
                    Singleton singleton2 = Singleton.GetInstance();
                    Singleton singleton3 = Singleton.GetInstance();

                    {
                        // 反射破环单例 可以访问私有构造函数
                        Assembly assembly = Assembly.Load("DB.SqlServer");
                        Type type = assembly.GetType("DB.SqlServer.Singleton");
                        Singleton singleton4 = (Singleton)Activator.CreateInstance(type, true);
                        Singleton singleton5 = (Singleton)Activator.CreateInstance(type, true);
                        Singleton singleton6 = (Singleton)Activator.CreateInstance(type, true);


                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
