using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine(typeof(List<>));//`1 占位符 1个参数
                Console.WriteLine(typeof(Dictionary<,>));//`2

                int iValue = 123;
                // var iValue = 123;
                string sValue = "456";
                DateTime dtValue = DateTime.Now;
                object oValue = "Jonty";

                Console.WriteLine("*************************");
                CommonMethod.ShowInt(iValue);
                CommonMethod.ShowString(sValue);
                CommonMethod.ShowDateTime(dtValue);
                CommonMethod.ShowObject(oValue);

                // 全部用ShowObject
                CommonMethod.ShowObject(sValue);
                CommonMethod.ShowObject(iValue);
                CommonMethod.ShowObject(dtValue);

                Console.WriteLine("************Generic***********");
                GenericMethod.Show<int>(iValue);
                // 可省略 自动推断
                GenericMethod.Show(sValue);
                GenericMethod.Show<DateTime>(dtValue);

                Console.WriteLine("*************Monitor************");
                // common~=generic > object
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
