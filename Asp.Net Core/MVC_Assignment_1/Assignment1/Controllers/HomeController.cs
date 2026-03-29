using System.Diagnostics;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Welcome to ASP.NET Core MVC");
        }

        public IActionResult About()
        {
            return Content("This is About Page");
        }

        public IActionResult Contact()
        {
            return Content("Contact us at support@test.com");
        }
    }
}
