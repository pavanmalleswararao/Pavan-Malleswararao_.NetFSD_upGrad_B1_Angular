using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace C__Inheritance_Assignment_Education
{
    class Student
    {
        public long StudentId { get; set; }
        public string Name { get; set; }
        public int Marks {  get; set; }
        public Student(long studentId, string name, int marks)
        {
            StudentId = studentId;
            Name = name;
            Marks = marks;
        }

        public virtual string CalculateGrade()
        {
            if (Marks > 50)
                return "Pass";
            else
                return "Fail";
        }
    }
    class SchoolStudent : Student
    {
        public SchoolStudent(long studentId, string name, int marks) : base(studentId, name, marks)
        {
        }

        public override string CalculateGrade()
        {
            if (Marks > 40)
                return "Pass";
            else
                return "Fail";
        }
    }
    class CollegeStudent : Student
    {
        public CollegeStudent(long studentId, string Name, int Marks):base(studentId, Name, Marks)
        {

        }
        public override string CalculateGrade()
        {
            if (Marks > 50)
                return "Pass";
            else
                return "Fail";
        }
    }
    class OnlineStudent : Student
    {
        public OnlineStudent(long studentId, string Name, int Marks) : base(studentId, Name, Marks)
        {

        }
        public override string CalculateGrade()
        {
            if (Marks > 60)
                return "Pass";
            else
                return "Fail";
        }
    }
}
