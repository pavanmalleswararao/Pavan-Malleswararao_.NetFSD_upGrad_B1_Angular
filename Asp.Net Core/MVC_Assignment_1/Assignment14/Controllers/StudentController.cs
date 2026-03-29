using Assignment14.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment14.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            Student s=new Student()
            {
                Name="Pavan",
                Age=22
            };
            return View(s);
        }
    }
}
