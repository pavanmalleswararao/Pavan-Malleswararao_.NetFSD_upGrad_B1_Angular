using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignments
{
    public record Product(int Id, string Name, string Category, double price, int stock);
    internal class Assignment7
    {
        static void Main()
        {
            List<Product> products = new List<Product>()
            {
                new Product(1,"Laptop","Eletronics",80000,5),
                new Product(2,"Mobile","Eletronics",20000,20),
                new Product(3,"Shoes","Fashion",2000,8),
                new Product(4,"Watch","Fashion",5000,0),
                new Product(5,"TV","Electronics",60000,12)
            };

            var lowStock = products.Where(p => p.stock < 10);
            foreach (var p in lowStock)
                Console.WriteLine(p);
            Console.WriteLine();

            var top3 = products.OrderByDescending(p => p.price).Take(3);
            foreach (var p in top3)
                Console.WriteLine(p);
            Console.WriteLine();

            var groupByCategory = products.GroupBy(p => p.Category);
            foreach (var p in groupByCategory)
            {
                foreach (var i in p)
                    Console.WriteLine(i);
            }
            Console.WriteLine();

            var totalStock = groupByCategory.Select(g => new { category = g.Key, TotalStock = g.Sum(p => p.stock) });
            foreach (var p in totalStock)
                Console.WriteLine(p);
            Console.WriteLine();

            bool outOfStock = products.Any(p => p.stock == 0);
            Console.WriteLine("Stock Exists:"+outOfStock);
        }
    }
}
