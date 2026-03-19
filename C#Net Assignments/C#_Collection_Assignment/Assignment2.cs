using System;
using System.Collections.Generic;
using System.Text;

namespace C__Collection_Assignment_Student_Management_System
{
    internal class Student
    {
        public int Id;
        public string Name;
        public int Marks;
    }
    class Program
    {
        static void Main()
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {1, new Student{Id=1, Name="Pavan", Marks=80}},
                {2, new Student{Id=2, Name="Ravi", Marks=70}},
                {3, new Student{Id=3, Name="Sita", Marks=90}},
                {4, new Student{Id=4, Name="Anu", Marks=60}},
                {5, new Student{Id=5, Name="Kiran", Marks=85}}
            };

            Console.WriteLine(students[1].Name);

            Console.WriteLine(students.ContainsKey(3));

            students[2].Marks = 75;

            students.Remove(4);

            Console.WriteLine("\nMarks>75");
            foreach(var s in students.Values)
            {
                if (s.Marks > 75)
                {
                    Console.WriteLine(s.Name);
                }
            }
        }
    }
}
