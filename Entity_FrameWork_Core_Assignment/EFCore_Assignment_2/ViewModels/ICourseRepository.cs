using EFCore_Assignment_2.Models;

namespace EFCore_Assignment_2.ViewModels
{
    public interface ICourseRepository
    {
        List<Course> GetAll();

        void Add(Course course);
    }
}
