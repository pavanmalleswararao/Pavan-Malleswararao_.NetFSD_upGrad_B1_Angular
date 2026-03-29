using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Details(String name, int age)
        {
            return Content($"Name: {name} Age: {age}");
        }
    }
}
