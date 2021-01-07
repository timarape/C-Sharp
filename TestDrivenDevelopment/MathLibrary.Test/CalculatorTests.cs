using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathLibrary.Test
{
    [TestClass]
    public class CalculatorTests
    {
        Calculator calculator;

        [TestInitialize]
        public void SetUp()
        {
            calculator = new Calculator();

        }

        [TestMethod]
        public void AddNumbers_GivenTwoNumbers_ReturnsTheSum()
        {
            int firstNumber = 5;
            int secondNumber = 2;

            var result = calculator.AddNumbers(firstNumber, secondNumber);

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Max_GivenTwoNumbers_ReturnsGreaterNumber()
        {
            int firstNumber = 2;
            int secondnumber = 4;

            var result = calculator.Max(firstNumber,secondnumber);

            Assert.AreEqual(4, result);

        }
       

    }
}
