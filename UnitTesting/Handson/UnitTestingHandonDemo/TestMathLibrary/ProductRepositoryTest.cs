using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;

namespace TestMathLibrary
{
    internal class ProductRepositoryTest
    {
        [Test]
        public void Test_Details()
        {
            //Arrange
            ProductRepository repository = new ProductRepository();
            int id = 1;
            //Act
            var Product = repository.Detail(id);
            //Assert
            Assert.That(Product, Is.Not.Null);
            Assert.That(id, Is.EqualTo(Product.Id));
        }
        [Test]
        public void Test_GetAll()
        {
            //Arrange
            ProductRepository repository= new ProductRepository();
            //Act
            var products = repository.GetProducts();
            //Arrage
            Assert.That(products.Count, Is.GreaterThan(0));
        }
    }
}
