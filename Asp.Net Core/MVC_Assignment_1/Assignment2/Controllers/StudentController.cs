using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return Content("Student Index Page");
        }
        public IActionResult Profile()
        {
            return Content("Student Profile Page");
        }
    }
}
