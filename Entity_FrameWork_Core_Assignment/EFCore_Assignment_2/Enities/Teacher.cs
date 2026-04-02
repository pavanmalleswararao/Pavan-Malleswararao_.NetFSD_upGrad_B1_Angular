using System;
using System.Collections.Generic;

namespace EFCore_Assignment_2.Enities;

public partial class Teacher
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}
