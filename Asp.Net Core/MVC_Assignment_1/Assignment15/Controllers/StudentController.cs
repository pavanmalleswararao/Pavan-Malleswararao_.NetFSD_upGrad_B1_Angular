using Microsoft.AspNetCore.Mvc;

namespace Assignment15.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(string name, int age)
        {
            ViewData["Message"] = "Student Details Page";
            ViewBag.IsEligible = age > 18;
            return View(model: (name, age));
        }
    }
}
