using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignments_Custom_Sorting
{
    public record Employee(int Id, string Name, string Department, double Salary);
    internal class Assignment10
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1,"Ravi","IT",50000),
                new Employee(2,"Kiran","HR",65000),
                new Employee(3,"Sam","IT",70000),
                new Employee(4,"Amit","HR",45000),
                new Employee(5,"Raj","IT",55000)
            };

            var sorted = employees.OrderBy(e => e.Department).ThenByDescending(e => e.Salary);
            foreach (var emp in sorted)
                Console.WriteLine(emp);
        }
    }
}
