using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignments_Complex_Dashboard
{
    public record Employee(int Id, string Name, string Department, double Salary, DateTime JoiningDate);
    internal class Assignment15
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1,"A","IT",50000,DateTime.Now.AddMonths(-2)),
                new Employee(2,"B","HR",40000,DateTime.Now.AddMonths(-8)),
                new Employee(3,"C","IT",70000,DateTime.Now.AddMonths(-1)),
                new Employee(4,"D","HR",45000,DateTime.Now.AddMonths(-3)),
            };

            int totalEmployees = employees.Count();
            Console.WriteLine(totalEmployees);
            Console.WriteLine();

            var avgSalary = employees.GroupBy(e => e.Department).Select(g => new { Department = g.Key, AvgSalary = g.Average(x => x.Salary) });
            foreach (var emp in avgSalary)
                Console.WriteLine(emp);
            Console.WriteLine();

            var recentEmployees = employees.Where(e => e.JoiningDate > DateTime.Now.AddMonths(-6));
            foreach (var emp in recentEmployees)
                Console.WriteLine(emp);
            Console.WriteLine();

            var highestPaid = employees.GroupBy(e => e.Department).Select(g => g.OrderByDescending(e => e.Salary).First());
            foreach (var emp in highestPaid)
                Console.WriteLine(emp);
            Console.WriteLine();

            var salaryStats = new {Min=employees.Min(e=>e.Salary), Max=employees.Max(e=>e.Salary), Avg=employees.Average(e=>e.Salary)};
            Console.WriteLine(salaryStats);
        }
    }
}
