using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_Assignment_2.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string? Name { get; set; }
        [EmailAddress]
        public string? Email {  get; set; }
        public List<Enrollment>? enrollments { get; set; }
    }
}
