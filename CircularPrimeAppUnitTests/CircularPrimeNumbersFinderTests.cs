using System.Collections.Generic;
using CircularPrimeApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircularPrimeAppUnitTests
{
    [TestClass]
    public class CircularPrimeNumbersFinderTests
    {
        [TestMethod]
        public void CalculateCircularPrimeNumbersCount_ShouldReturn13_WhenMaxNumberIs100()
        {
            //Arrange
            var testPrimeList = new HashSet<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            const int expectedCount = 13;
            const int maxNumber = 100;

            //Act
            var actualCount = CircularPrimeNumbersFinder.CalculateCircularPrimeNumbersCount(testPrimeList, maxNumber);

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void CalculateCircularPrimeNumbersCount_ShouldReturn0_WhenMaxNumberIs1()
        {
            //Arrange
            var testPrimeList = new HashSet<int> {2, 3, 5, 7};
            const int expectedCount = 0;
            const int maxNumber = 1;

            //Act
            var actualCount = CircularPrimeNumbersFinder.CalculateCircularPrimeNumbersCount(testPrimeList, maxNumber);

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
