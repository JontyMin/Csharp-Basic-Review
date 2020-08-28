using System;
using DB.Interface;

namespace DB.MySQL
{
    public class MySQLHelper : IDBHelper
    {
        public MySQLHelper()
        {
            Console.WriteLine($"{this.GetType().Name}被构造");
        }


        public void Query()
        {
            Console.WriteLine($"{this.GetType().Name}.Query");
        }
    }
}