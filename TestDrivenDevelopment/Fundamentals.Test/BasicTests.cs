using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Fundamentals
{
    [TestClass] 
    public class BasicTests
    {
        Basic basic;

        [TestInitialize]
        public void SetUp()
        {
           basic = new Basic();
        }

        [TestMethod]
        public void DivideNumbers_WhenCalled_ReturnsQuotient()
        {
            var result = basic.DivideNumbers(4, 2);

            Assert.AreEqual(2,result);

        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideNumbers_WhenCalledWithDenominatorOfZero_ReturnsDivideByZeroException()
        {
            basic.DivideNumbers(2,0);
        }

        [TestMethod]
        public void Swap_GivenTwoNumber_ReturnsSwappedValues()
        {
            var result = basic.Swap(2,3);

            Assert.AreEqual("32", result);

        }
    }
}
