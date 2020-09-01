using System;

namespace MyAttribute
{
    // [Serializable]
    [Custom]
    [Custom(123)]
    [Custom(123,Description = "123",Remark = "11231")] // 方法不可以
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Study()
        {
            Console.WriteLine($"这里是{this.Name}同学");
        }

        [Custom()]// 方法特性
        [return:Custom()] //  返回值特性
        public string Answer([Custom]string name) // 参数特性
        {
            return $"this is {name}";
        }
    }
}