using EFCore_Assignment_2.Models;

namespace EFCore_Assignment_2.ViewModels
{
    public class CourseRepository:ICourseRepository
    {
        private readonly AppDBContext _context;
        public CourseRepository(AppDBContext context)
        {
            _context = context;
        }

        void ICourseRepository.Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        List<Course> ICourseRepository.GetAll()
        {
            return _context.Courses.ToList();
        }
    }
}
