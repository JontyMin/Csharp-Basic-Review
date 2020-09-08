using System;

namespace MyDelegateEvent
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ClassId { get; set; }

        public void Study()
        {
            Console.WriteLine("学习委托");
        }

        public static void StudyAdvanced()
        {
            Console.WriteLine("学习委托和事件");
        }

        public static void Show()
        {
            Console.WriteLine("123");
        }
    }
}