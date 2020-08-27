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

                Generic<int>generic = new Generic<int>()
                {
                    _t=123
                };


                {
                    People people = new People()
                    {
                        Id = 12,
                        Name = "走自己的路"
                    };
                    Chinese chinese = new Chinese()
                    {
                        Id = 34,
                        Name = "Jonty"
                    };
                    HuNan huNan = new HuNan()
                    {
                        Id = 45,
                        Name="长沙"
                    };
                    Japanese japanese =  new Japanese()
                    {
                        Id = 56,
                        Name = "波多"
                    };

                    CommonMethod.ShowObject(people);
                    CommonMethod.ShowObject(chinese);
                    CommonMethod.ShowObject(huNan);
                    CommonMethod.ShowObject(japanese);

                    GenericMethod.Show(people);
                    GenericMethod.Show(chinese);
                    GenericMethod.Show(huNan);
                    GenericMethod.Show(japanese);
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
