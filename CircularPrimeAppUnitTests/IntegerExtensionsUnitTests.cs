using CircularPrimeApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircularPrimeAppUnitTests
{
    [TestClass]
    public class IntegerExtensionsUnitTests
    {
        [TestMethod]
        public void FindIntegerDigitsCount_ShouldReturnTwo_WhenPositiveIntegerConsitsOFTwoDigits()
        {
            //Arrange
            const int testInteger = 40;
            const int expectedCount = 2;

            //Act
            var actualCount = testInteger.GetDigitsCount();

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void FindIntegerDigitsCount_ShouldReturnTwo_WhenNegativeIntegerConsitsOFTwoDigits()
        {
            //Arrange
            const int testInteger = -40;
            const int expectedCount = 2;

            //Act
            var actualCount = testInteger.GetDigitsCount();

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void FindIntegerDigitsCount_ShouldReturnOne_WhenIntegerIs0()
        {
            //Arrange
            const int testInteger = 0;
            const int expectedCount = 1;

            //Act
            var actualCount = testInteger.GetDigitsCount();

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void IsIntegerPowerOfTen_ShouldReturnTrue_WhenIntegerIsPowerOfTen()
        {
            //Arrange
            const int testInteger = 1000000;

            //Act
            var result = testInteger.IsPowerOfTen();

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsIntegerPowerOfTen_ShouldReturnFalse_WhenIntegerIsNotPowerOfTen()
        {
            //Arrange
            const int testInteger = 50;

            //Act
            var result = testInteger.IsPowerOfTen();

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsIntegerPowerOfTen_ShouldReturnFalse_WhenIntegerIs1()
        {
            //Arrange
            const int testInteger = 1;

            //Act
            var result = testInteger.IsPowerOfTen();

            //Assert
            Assert.IsFalse(result);
        }
    }
}
