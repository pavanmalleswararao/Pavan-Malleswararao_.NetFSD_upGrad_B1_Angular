using Microsoft.AspNetCore.Mvc;

namespace Assignment4.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProduct(int id)
        {
            return Content($"Product Id is: {id}");
        }
    }
}
