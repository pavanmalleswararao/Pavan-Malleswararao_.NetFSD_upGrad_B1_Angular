using EFCore_Assignment_2.Models;

namespace EFCore_Assignment_2.ViewModels
{
    public class StudentRepository:IStudentRepository
    {
        private readonly AppDBContext _context;
        public StudentRepository(AppDBContext context)
        {
            _context = context;
        }

        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == Id);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int Id)
        {
            return _context.Students.Find(Id);
        }

        public void Update(Student student)
        {
            
            _context.Students.Update(student);
            _context.SaveChanges();
        }
    }
}
