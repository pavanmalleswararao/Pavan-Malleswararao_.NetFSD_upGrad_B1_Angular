using System.ComponentModel.DataAnnotations;

namespace MVC_Assignment_3.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        [Required]
        [MinLength(6,ErrorMessage ="Minimum 6 characters")]
        public string Password {  get; set; }

        [Required]
        [Compare("Password",ErrorMessage ="Password do not Match")]
        public string ConformPassword { get; set; }
    }
}
