using EFCore_Assignment_2.Models;
using EFCore_Assignment_2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

namespace EFCore_Assignment_2.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository courseRepository;
        public CourseController(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }
        public IActionResult Index()
        {
            return View(courseRepository.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course course)
        {
            courseRepository.Add(course);
            return RedirectToAction("Index");
        }
    }
}
