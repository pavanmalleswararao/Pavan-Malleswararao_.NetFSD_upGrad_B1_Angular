using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignments_E_Commerce
{
    public record Order(int Id, string CustomerName, DateTime OrderDate, double TotalAmount);
    internal class Assignment9
    {
        static void Main()
        {
            List<Order> orders = new List<Order>()
            {
                new Order(1,"Ravi",DateTime.Now.AddDays(-10),2000),
                new Order(2,"Amit",DateTime.Now.AddDays(-40),5000),
                new Order(3,"Ravi",DateTime.Now.AddDays(-5),3000),
                new Order(4,"Kiran",DateTime.Now.AddDays(-2),7000)
            };
            var last30Days = orders.Where(o => o.OrderDate >= DateTime.Now.AddDays(-30));
            foreach (var day in last30Days)
                Console.WriteLine(day);
            Console.WriteLine();

            var monthlySales = orders.GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month }).Select(g => new { g.Key.Year, g.Key.Month, Totalsales = g.Sum(x => x.TotalAmount) });
            foreach(var sales in monthlySales)
            {
                Console.WriteLine(sales);
            }
            Console.WriteLine();

            var topCustomers = orders.GroupBy(o => o.CustomerName).Select(g => new {customer=g.Key,Total=g.Sum(x=>x.TotalAmount)}).OrderByDescending(x=>x.Total).Take(5);
            foreach (var top in topCustomers)
                Console.WriteLine(top);
            Console.WriteLine();

            var highest = orders.GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month }).Select(g => g.OrderByDescending(x => x.TotalAmount).First());
            foreach (var high in highest)
                Console.WriteLine(high);
        }
    }
}
