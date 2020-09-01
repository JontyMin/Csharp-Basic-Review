using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DB.Interface;
using DB.MySQL;
using DB.SqlServer;
using Model;

namespace Reflection
{
    /// <summary>
    /// 反射：System.Reflection .Net框架类库，可以读取并使用metadata
    /// 反射优点：动态
    ///     缺点：1.复杂
    ///          2.避开编译器检查
    ///          3.性能问题
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                #region IOC使用

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

                    {
                        // 有参构造函数
                        
                        Assembly assembly = Assembly.Load("DB.SqlServer");
                        
                        Type type = assembly.GetType("DB.SqlServer.ReflectionTest");
                        
                        object oReflectionTest1 = Activator.CreateInstance(type);
                        object oReflectionTest2 = Activator.CreateInstance(type,new object[]{123});
                        object oReflectionTest3 = Activator.CreateInstance(type,new object[]{"123"});
                    }

                    {
                        // 泛型
                        Assembly assembly = Assembly.Load("DB.SqlServer");
                        
                        Type type = assembly.GetType("DB.SqlServer.GenericTest`3");
                        
                        // object oGeneric = Activator.CreateInstance(type);
                        
                        Type newType = type.MakeGenericType(new Type[] {typeof(int), typeof(string), typeof(DateTime)});
                        
                        object oGeneric = Activator.CreateInstance(newType);

                    }
                } 
                #endregion

                #region MVC

                {
                    // MVC URL地址——类名称+方法
                   Console.WriteLine("*********Reflection+Method****************");
                   
                   Assembly assembly = Assembly.Load("DB.SqlServer");
                   
                   Type type = assembly.GetType("DB.SqlServer.ReflectionTest");
                   
                   object oReflectionTest = Activator.CreateInstance(type);
                   
                   {
                       MethodInfo method = type.GetMethod("Show1");
                       
                       method.Invoke(oReflectionTest, null);
                   }
                   {
                       MethodInfo method = type.GetMethod("Show2");
                       
                       method.Invoke(oReflectionTest, new object[]{123});
                   }
                   {
                       MethodInfo method = type.GetMethod("Show5");
                       
                       method.Invoke(oReflectionTest, new object[]{"WebApi实践"});
                       
                       // 可以没有实例
                       method.Invoke(null, new object[]{"WebApi实践"});
                   }
                   {
                       MethodInfo method = type.GetMethod("Show3", new Type[] {typeof(int) ,typeof(string)});
                       
                       method.Invoke(oReflectionTest, new object[] {123,"Jonty"});
                   }
                   {
                       // 私有方法
                       MethodInfo method = type.GetMethod("Show4",BindingFlags.Instance|BindingFlags.NonPublic);
                       
                       method.Invoke(oReflectionTest, new object[]{"Jonty"});
                   }

                }

                {
                    // 泛型
                    Assembly assembly = Assembly.Load("DB.SqlServer");

                    Type type = assembly.GetType("DB.SqlServer.GenericDouble`1");
                    
                    Type newType = type.MakeGenericType(new Type[] { typeof(int) });
                    
                    object oGeneric = Activator.CreateInstance(newType);
                   
                    MethodInfo method = newType.GetMethod("Show");
                    
                    MethodInfo newMethod = method.MakeGenericMethod(new Type[] {typeof(string), typeof(DateTime)});
                    
                    newMethod.Invoke(oGeneric, new object[] {123, "杀手", DateTime.Now});
                }
                #endregion
                */
                #region ORM使用
                /*
                {
                    Console.WriteLine("********Reflection+Property/Field************");
                    
                    People people = new People();
                    
                    people.Id = 123;
                    people.Name = "Jonty";
                    people.Description = "待业游民";
                    
                    Console.WriteLine($"people.Id={people.Id},people.Name={people.Name},people.Description={people.Description}");

                    Type type = typeof(People);

                    object oPeople = Activator.CreateInstance(type);

                    // GetProperties获取全部属性
                    foreach (var item in type.GetProperties())
                    {
                        Console.WriteLine(type.Name);

                        // 获取属性名
                        Console.WriteLine(item.Name);

                        // 获取属性值
                        Console.WriteLine(item.GetValue(oPeople));

                        // 设置值
                        if (item.Name.Equals("Id"))
                        {
                            item.SetValue(oPeople,234);
                        }else if (item.Name.Equals("Name"))
                        {
                            item.SetValue(oPeople,"Func");
                        }

                        Console.WriteLine($"{type.Name}.{item.Name}={item.GetValue(oPeople)}");

                    }

                    // 获取字段
                    foreach (var filed in type.GetFields())
                    {
                        Console.WriteLine(type.Name);
                        Console.WriteLine(filed.Name);
                        Console.WriteLine(filed.GetValue(oPeople));
                        if (filed.Name.Equals("Description"))
                        {
                            filed.SetValue(oPeople,"哈哈大呆头");
                        }
                        Console.WriteLine($"{type.Name}.{filed.Name}={filed.GetValue(oPeople)}");

                    }
                }
                
                {
                    People people = new People();

                    people.Id = 123;
                    people.Name = "Jonty";
                    people.Description = "待业游民";

                    // 硬编码
                    PeopleDto peopleDto = new PeopleDto()
                    {
                        Id=people.Id,
                        Name = people.Name,
                        Description = people.Description
                    };
                }

                {

                    People people = new People();

                    people.Id = 123;
                    people.Name = "Jonty";
                    people.Description = "待业游民";
                    {
                        Type typePeople = typeof(People);

                        Type typePeopleDto = typeof(PeopleDto);

                        object peopleDto = Activator.CreateInstance(typePeopleDto);

                        // 获取属性
                        foreach (var prop in typePeopleDto.GetProperties())
                        {
                            // if (prop.Name.Equals("Id"))
                            // {
                            //     // object value = typePeople.GetProperty("Id").GetValue(people);
                            //     object value = typePeople.GetProperty(prop.Name).GetValue(people);
                            //
                            //     prop.SetValue(peopleDto, value);
                            //
                            // }else if (prop.Name.Equals("Name"))
                            // {
                            //     // object value = typePeople.GetProperty("Name").GetValue(people);
                            //     object value = typePeople.GetProperty(prop.Name).GetValue(people);
                            //
                            //     prop.SetValue(peopleDto, value);
                            // }
                            object value = typePeople.GetProperty(prop.Name).GetValue(people);
                            prop.SetValue(peopleDto, value);

                        }
                        
                        // 获取字段
                        foreach (var field in typePeopleDto.GetFields())
                        {
                            object value = typePeople.GetField(field.Name).GetValue(people);
                            field.SetValue(peopleDto, value);
                        }
                    }
                   

                }
                */

                #endregion

                Monitor.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
