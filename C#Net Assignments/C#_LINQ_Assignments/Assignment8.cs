using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignments_student
{
    public record Student(int Id, string Name, string Class, string Subject, int Marks);
    internal class Assignment8
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student(1,"A","10","Math",90),
                new Student(2,"B","10","Science",80),
                new Student(3,"C","10","Math",70),
                new Student(4,"D","9","Math",85)
            };

            var result = students.GroupBy(s => s.Class).Select(ClassGroup => new { Class = ClassGroup.Key, Subjects = ClassGroup.GroupBy(s => s.Subject).Select(subjectGroup => new { subject = subjectGroup.Key, AverageMarks = subjectGroup.Average(s => s.Marks) }) });
            foreach(var c in result)
            {
                Console.WriteLine("Class: " + c.Class);
                foreach (var s in c.Subjects)
                    Console.WriteLine($"{s.subject}-{s.AverageMarks}");
            }
        }
    }
}
