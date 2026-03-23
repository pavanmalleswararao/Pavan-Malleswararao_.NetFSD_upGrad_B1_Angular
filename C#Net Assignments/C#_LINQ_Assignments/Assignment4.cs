using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignments
{
    public record Employee(int Id, string Name, string Department, double Salary);
    internal class Assignment4
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

            var itemp = employees.Where(e => e.Department == "IT");
            foreach (var i in itemp)
                Console.WriteLine(i.Name);
            Console.WriteLine();

            var highSalary = employees.OrderByDescending(e => e.Salary).First();
            Console.WriteLine(highSalary);
            Console.WriteLine();

            var avgSalary = employees.Average(e => e.Salary);
            Console.WriteLine(avgSalary);
            Console.WriteLine();

            var depart = employees.GroupBy(e => e.Department);
            foreach(var emp in depart)
            {
                Console.WriteLine(emp.Key);
                foreach (var e in emp)
                    Console.WriteLine(e.Name);
                Console.WriteLine();
            }
            Console.WriteLine();

            var eachDepart = employees.GroupBy(e => e.Department).Select(g => new { Dept = g.Key, count = g.Count() });
            foreach(var emp in eachDepart)
            {
                Console.WriteLine(emp.Dept + ": " + emp.count);
            }
        }
    }
}
