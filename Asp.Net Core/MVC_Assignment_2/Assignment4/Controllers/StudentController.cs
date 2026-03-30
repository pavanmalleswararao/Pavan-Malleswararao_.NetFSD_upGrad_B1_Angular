using Microsoft.AspNetCore.Mvc;

namespace Assignment4.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.StudentName = "Pavan";
            ViewData["StudentAge"] = 22;
            return View();
        }
    }
}
