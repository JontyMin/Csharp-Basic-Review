using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAttribute.Extension;

namespace MyAttribute
{
    /// <summary>
    /// 特性：中括号声明
    /// 每个特性都能对应一个功能
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UserState userState = UserState.Delete;
                // if (userState==UserState.Delete)
                // {
                //     Console.WriteLine("这是删除状态");
                // }
                // else if (userState==UserState.Frozen)
                // {
                //     Console.WriteLine("这是冻结状态");
                // }
                // else
                // {
                //     Console.WriteLine("这是正常状态");
                // }

                Console.WriteLine(userState.GetRemark());
                Console.WriteLine(UserState.Normal.GetRemark());

                Student s = new Student()
                {
                    QQ = 50121
                };
                Console.WriteLine(s.QQ);
                Console.WriteLine( s.Validate());
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
