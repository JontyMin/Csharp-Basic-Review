using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDelegateEvent;
using MyDelegateEvent.DelegateExtend;

namespace MyDelegateEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate=new MyDelegate();
            myDelegate.Show();

            ListExtend list = new ListExtend();
            list.Show();

           
        }
    }
}
