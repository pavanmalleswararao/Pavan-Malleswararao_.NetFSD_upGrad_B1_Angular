using EFCore_Assignment_2.Models;

namespace EFCore_Assignment_2.ViewModels
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student GetById(int Id);
        void Add(Student student);
        void Update(Student student);
        void Delete(int Id);
    }
}
