namespace EFCore_Assignment_2.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int studentId {  get; set; }
        public Student? Student { get; set; }
        public int courseId {  get; set; }
        public Course? Course { get; set; }
        public char? Grade { get; set; }
    }
}
