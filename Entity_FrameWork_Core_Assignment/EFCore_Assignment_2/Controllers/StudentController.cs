using EFCore_Assignment_2.Models;
using EFCore_Assignment_2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EFCore_Assignment_2.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepo;
        public StudentController(IStudentRepository studentRepo)
        {
            this.studentRepo = studentRepo;
        }
        public IActionResult Index()
        {
            var students = studentRepo.GetAll();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                studentRepo.Add(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        public IActionResult Edit(int Id)
        {
            return View(studentRepo.GetById(Id));
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            studentRepo.Update(student);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            studentRepo.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}
