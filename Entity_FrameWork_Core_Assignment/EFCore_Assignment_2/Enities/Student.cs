using System;
using System.Collections.Generic;

namespace EFCore_Assignment_2.Enities;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
