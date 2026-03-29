using Microsoft.AspNetCore.Mvc;

namespace Assignment5.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Add(int a, int b)
        {
            return Content($"Sum= {a+b}");
        }
        public IActionResult Multiply(int a, int b)
        {
            return Content($"Multiply= {a * b}");
        }
    }
}
