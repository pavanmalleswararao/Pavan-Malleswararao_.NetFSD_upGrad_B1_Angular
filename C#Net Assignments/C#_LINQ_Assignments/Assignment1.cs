using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignments
{
    public record Student(int Id, string name, int age, int marks);
    internal class Assignment1
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student(1,"Ravi",20,85),
                new Student(2,"Kiran",22,89),
                new Student(3,"Amit",21,60),
                new Student(4,"Sam",19,70),
                new Student(5,"Raj",26,80)
            };
            var highestMarks = students.Where(s => s.marks > 75);
            foreach (var i in highestMarks)
                Console.WriteLine(i);
            Console.WriteLine();

            var agefilter = students.Where(s => s.age>=18 && s.age <= 25);
            foreach (var a in agefilter)
                Console.WriteLine(a);
            Console.WriteLine();

            var sorted=students.OrderByDescending(s => s.marks);
            foreach (var i in sorted)
                Console.WriteLine(i);
            Console.WriteLine();

            var details = students.Select(s => new { s.name, s.marks });
            foreach (var d in details)
                Console.WriteLine(d);
            Console.WriteLine();
        }
    }
}
