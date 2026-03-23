using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace C__LINQ_Assignments
{
    public record Customer(int Id, string Name);
    public record Order(int Id, int customerId, double Amount);
    internal class Assignment5
    {
        static void Main()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer(1,"Ravi"),
                new Customer(2,"Kiran")
            };

            List<Order> orders = new List<Order>()
            {
                new Order(1,1,3000),
                new Order(2,1,4000)
            };

            var join = from c in customers
                       join o in orders
                       on c.Id equals o.customerId
                       select new { c.Name, o.Amount };
            foreach (var i in join)
                Console.WriteLine(i);
            Console.WriteLine();

            var total = orders.GroupBy(o => o.customerId).Select(g => new { ID = g.Key, Total = g.Sum(x => x.Amount) });
            foreach (var i in total)
            {
                Console.WriteLine(i.ID + ": " + i.Total);
            }
            Console.WriteLine();

            var rich = total.Where(x => x.Total > 5000);
            foreach(var i in rich)
                Console.WriteLine(i.ID+": "+i.Total);
            Console.WriteLine();

            var noOrder = customers.Where(c => !orders.Any(o => o.customerId == c.Id));
            foreach (var i in noOrder)
                Console.WriteLine(i);
        }
    }
}
