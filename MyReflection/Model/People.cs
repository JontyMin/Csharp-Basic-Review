using System;

namespace Model
{
    public class People
    {
        public People()
        {
            Console.WriteLine($"{this.GetType().FullName}被创建");
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Description;
    }
    public class PeopleDto
    {
        public PeopleDto()
        {
            Console.WriteLine($"{this.GetType().FullName}被创建");
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Description;
    }
}