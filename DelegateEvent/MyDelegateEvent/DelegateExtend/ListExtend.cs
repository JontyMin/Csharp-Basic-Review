using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDelegateEvent.DelegateExtend
{
    public class ListExtend
    {


        public delegate bool ThanDelegate(Student student);
        private bool AgeThan(Student student)
        {
            return student.Age > 10;
        }

        private bool LengthThan(Student student)
        {
            return student.Name.Length > 1;
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    Id = 2,
                    Name = "aa",
                    Age = 17,
                    ClassId = 2
                },
                new Student()
                {
                    Id = 3,
                    Name = "bb",
                    Age = 18,
                    ClassId = 2
                },
                new Student()
                {
                    Id = 4,
                    Name = "cc",
                    Age = 19,
                    ClassId = 3
                }
            };

            return students;
        }

        public void Show()
        {
            List<Student> students = this.GetStudents();

            // 找出年龄大于25的
            /* List<Student> result = new List<Student>();
             result = students.Where(x => x.Age > 10).ToList();
             foreach (var student in result)
             {
                 Console.WriteLine(student.Name);
             }*/

            // 准备容器
            //List<Student> result = new List<Student>();
            // 遍历
            // foreach (var student in result)
            // {
            //     // 判断
            //     if (student.Name.Length>2)
            //     {
            //         result.Add(student);
            //     }
            // }
            //
            // Console.WriteLine($"一共有{result.Count}");


            {
                ThanDelegate ageThanDelegate = new ThanDelegate(this.AgeThan);
                List<Student> result = this.GetStudentsDelegate(students, ageThanDelegate);
                foreach (var student in result)
                {
                    Console.WriteLine(student.Name);
                }

                ThanDelegate lengthThanDelegate = new ThanDelegate(this.LengthThan);
                List<Student> result1 =this.GetStudentsDelegate(students, lengthThanDelegate);

            }
        }

        /// <summary>
        /// 根据type不同的值进行判断
        /// 
        /// 传参数=>判断参数=>执行对应的行为
        ///
        /// 直接传递行为，传递方法
        /// </summary>
        /// <param name="students"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Student> GetStudents(List<Student> students,int type)
        {
            List<Student> result = new List<Student>();

            foreach (var student in students)
            {
                if (type == 1)
                {
                    if (student.Name.Length > 2)
                    {
                        result.Add(student);
                    }
                }
                else if (type == 2)
                {
                    if (student.Age > 10)
                    {
                        result.Add(student);
                    }
                }
                else
                {
                    if (student.Age == 2)
                    {
                        result.Add(student);
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 委托方式 传入判断逻辑
        /// 委托解耦：减少重复代码
        /// </summary>
        /// <param name="students"></param>
        /// <param name="thanDelegate"></param>
        /// <returns></returns>
        public List<Student> GetStudentsDelegate(List<Student> students, ThanDelegate thanDelegate)
        {
            List<Student> result = new List<Student>();

            foreach (var student in students)
            {
                if (thanDelegate.Invoke(student))
                {
                    result.Add(student);
                }
            }
            return result;
        }

    }
}