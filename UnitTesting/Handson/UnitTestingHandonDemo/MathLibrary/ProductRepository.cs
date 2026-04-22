using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
    public class ProductRepository
    {
        public Product Detail(int id)
        {
            return new Product(){
                Id=1,
                Name="Laptop",
                Price=50000,
            };
        }
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product(){Id=1,Name="Laptop",Price=50000},
                new Product(){Id=2,Name="Mouse",Price=600}
            };
        }
    }
}
