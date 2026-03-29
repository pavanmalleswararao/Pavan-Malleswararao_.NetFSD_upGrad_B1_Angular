using System.Diagnostics;
using Assignment13.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment13.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Student()
        {
            List<string> students=new List<string>()
            {
                "Pavan","Ravi","kiran"
            };
            ViewBag.Students = students;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
