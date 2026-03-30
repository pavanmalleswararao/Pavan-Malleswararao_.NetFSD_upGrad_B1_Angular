using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new Student()
            {
                ID = 1,
                Name = "Pavan",
                Age = 22,
                Email = "pavan@gmail.com"
            };
            return View(student);
        }
    }
}
