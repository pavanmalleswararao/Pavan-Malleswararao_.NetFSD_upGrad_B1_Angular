using System.Diagnostics;
using Assignment10.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment10.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            ViewData["Name"] = "Pavan";
            ViewData["Salary"] = 50000;
            ViewData["Department"] = "IT";
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
