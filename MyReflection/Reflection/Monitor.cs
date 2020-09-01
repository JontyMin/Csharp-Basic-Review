using System;
using System.Diagnostics;
using System.Reflection;
using DB.Interface;
using DB.SqlServer;

namespace Reflection
{
    public class Monitor
    {
        public static void Show()
        {
            Console.WriteLine("********性能测试************");
            long commonTime = 0;
            long reflectionTime = 0;
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                for (int i = 0; i < 1000000; i++)
                {
                    IDBHelper iDbHelper = new SqlServerHelper();
                    iDbHelper.Query();
                }
                watch.Stop();
                commonTime = watch.ElapsedMilliseconds;
            }
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                Assembly assembly = Assembly.Load("DB.SqlServer");

                Type type = assembly.GetType("DB.SqlServer.SqlServerHelper");

                for (int i = 0; i < 1000000; i++)
                {
                    
                    object oHelper = Activator.CreateInstance(type);

                    IDBHelper dbHelper = (IDBHelper) oHelper;
                    dbHelper.Query();
                   
                } 
                watch.Stop();
                reflectionTime = watch.ElapsedMilliseconds;
            }
            Console.WriteLine($"commonTime={commonTime},reflectionTime={reflectionTime}");
        }
    }
}