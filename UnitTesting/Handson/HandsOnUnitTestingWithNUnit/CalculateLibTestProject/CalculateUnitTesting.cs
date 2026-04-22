using System;
using System.Collections.Generic;
using System.Text;
using CalculateLibraryLibrary;
using NUnit.Framework.Legacy;

namespace CalculateLibTestProject
{
    [TestFixture]
    public class CalculateUnitTesting
    {
        private Calculate _calculate;
        [SetUp]
        public void SetUp()
        {
            _calculate = new Calculate();
        }
        [Test]
        public void Add_TwoPositiveIntegers_ReturnsSum()
        {
            //Arrange
            int a = 5;
            int b = 10;
            int expected = 15;
            //Act
            int actual=_calculate.Add(a, b);
            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }
        [Test]
        public void Multiply_TwoPositiveIntegers_ReturnsProduct()
        {
            //Arrange
            int a = 5;
            int b = 10;
            int expected = 50;
            //Act
            int actual=_calculate.Multiply(a, b);
            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }
        [Test]
        public void IsEven_EvenNumber_ReturnsTrue()
        {
            //Arrange
            int number = 4;
            //Act
            bool result=_calculate.IsEven(number);
            //Assert
            ClassicAssert.IsTrue(result);
        }
        [Test]
        [Ignore("This is ignored  for demonstration Purpose.")]
        public void IsEven_OddNumber_ReturnFalse()
        {
            //Arrange
            int number = 5;
            //Act
            bool result=_calculate.IsEven(number);
            //Assert
            ClassicAssert.IsFalse(result);
        }
        [Test]
        [TestCase(10,2,5)]
        [TestCase(20,4,5)]
        [TestCase(15,3,5)]
        public void Divide_ValidInputs_ReturnsQuotient(int a, int b,int expected)
        {
            //Act
            int actual=_calculate.Divide(a,b);
            //Assert
            ClassicAssert.AreEqual(expected,actual);
        }
        [Test]
        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown:This is runs after each test.");
            _calculate = null;
        }
        [Test]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            //Arrange
            int a = 10;
            int b = 0;
            //Act & Assert
            var ex = Assert.Throws<DivideByZeroException>(() => _calculate.Divide(a, b));

        }
    }
}
