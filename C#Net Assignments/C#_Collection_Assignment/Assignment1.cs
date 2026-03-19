using System;
using System.Collections.Generic;
using System.Text;

namespace C__Collection_Assignment_E_Commerce
{
    internal class Product
    {
        public int Id;
        public string Name;
        public double Price;
        public string Category;
    }
    class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1, Name="Laptop", Price=50000, Category="Electronics"},
                new Product{Id=2, Name="Mobile", Price=20000, Category="Electronics"},
                new Product{Id=3, Name="Shoes", Price=1500, Category="Fashion"},
                new Product{Id=4, Name="Watch", Price=2500, Category="Fashion"},
                new Product{Id=5, Name="TV", Price=40000, Category="Electronics"},
                new Product{Id=6, Name="Bag", Price=800, Category="Fashion"},
                new Product{Id=7, Name="Headphones", Price=1200, Category="Electronics"},
                new Product{Id=8, Name="Keyboard", Price=900, Category="Electronics"},
                new Product{Id=9, Name="Mouse", Price=600, Category="Electronics"},
                new Product{Id=10, Name="Table", Price=3000, Category="Furniture"}
            };
            Console.WriteLine("All Products:");
            products.ForEach(p => Console.WriteLine($"{p.Name} - {p.Price}"));

            Console.WriteLine("\nPrice > 1000:");
            var filter = products.Where(p=> p.Price>1000);
            foreach (var p in filter)
                Console.WriteLine(p.Name);

            Console.WriteLine("\nAssending:");
            var asc = products.OrderBy(p=>p.Price);
            foreach (var p in asc)
                Console.WriteLine(p.Name+" "+p.Price);

            Console.WriteLine("\nDesending:");
            var desc=products.OrderBy(p=>p.Price);
            foreach (var p in desc) 
                Console.WriteLine(p.Name+" "+p.Price);

            products.RemoveAll(p => p.Id == 3);

            Console.WriteLine("\nFilter by Category (Eletronics):");
            var eletronics = products.Where(p=>p.Category=="Eletronics");
            foreach(var p in eletronics)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}
