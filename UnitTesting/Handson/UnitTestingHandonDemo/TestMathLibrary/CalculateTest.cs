using MathLibrary;

namespace TestMathLibrary
{
    public class Tests
    {
        private Calculate? calculate = null;
        [SetUp]
        public void Setup()
        {
            //Arrange
            calculate = new Calculate();
        }
        [TearDown]
        public void TearDown()
        {
            calculate = null;
        }

        [Test]
        public void Test_Add()
        {
            
            int expected = 5;
            //Act
            int actual = calculate.Add(2, 3);
            //Assert
            Assert.That(expected,Is.EqualTo(actual));
        }

        [Test]
        public void Test_IsEven_Fail()
        {
            //Act
            bool actual = calculate.IsEven(3);
            //Assert
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Test_IsEven_Pass()
        {
            //Act
            bool actual = calculate.IsEven(4);
            //Assert
            Assert.That(actual, Is.True);
        }
    }
}
