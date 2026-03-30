using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>()
        {
            new Student{Id=1,Name="Pavan",Age=22,Email="pavan@gmail.com",
            Courses=new List<Course>{
                new Course{CourseId=101,CourseName="C#",StudentId=1},
                new Course{CourseId=102,CourseName="Asp.net",StudentId=1} } },
            new Student{Id=2,Name="Ravi",Age=21,Email="ravi@gmail.com",
            Courses=new List<Course>{
                new Course{ CourseId=102,CourseName="Asp.net",StudentId=2} } }
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            var student=students.FirstOrDefault(s=>s.Id==id);
            if (student == null)
            {
                return NotFound("Student Not Found");
            }
            return View(student);
        }
    }
}
