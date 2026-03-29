using Microsoft.AspNetCore.Mvc;

namespace Assignment7.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            ViewBag.Name = "Pavan";
            ViewBag.Age = 22;
            return View();
        }
    }
}
