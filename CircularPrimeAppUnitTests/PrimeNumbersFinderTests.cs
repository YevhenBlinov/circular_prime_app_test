using CircularPrimeApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircularPrimeAppUnitTests
{
    [TestClass]
    public class PrimeNumbersFinderTests
    {
        [TestMethod]
        public void GetPrimeNumbers_ShouldReturn25PrimeNumbers_WhenMaxNumberIs100()
        {
            //Arrange
            const int maxNumber = 100;
            const int expectedCount = 25;

            //Act
            var primeNumbersList = PrimeNumbersFinder.GetPrimeNumbers(maxNumber);
            var actualCount = primeNumbersList.Count;

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void GetPrimeNumbers_ShouldReturn0PrimeNumbers_WhenMaxNumberIs1()
        {
            //Arrange
            const int maxNumber = 1;
            const int expectedCount = 0;

            //Act
            var primeNumbersList = PrimeNumbersFinder.GetPrimeNumbers(maxNumber);
            var actualCount = primeNumbersList.Count;

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
