using System;

namespace CircularPrimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter max number");

            var maxNumber = 0;

            if (!int.TryParse(Console.ReadLine(), out maxNumber) || maxNumber <= 0)
            {
                Console.WriteLine("Data must be positive integer.");
                return;
            }

            var maxNumberDigitsCount = maxNumber.GetDigitsCount();
            // This variable is needed for the correct work of method CalculateCircularPrimeNumbersCount. 
            // In the method we should be able to make sure that the number that is returned from private method RotatePrime
            // is also prime, that's why we need list of all prime numbers up to max n-digit number, where n is digit count of maxNumber.
            var primeLimit = maxNumber.IsPowerOfTen()
                ? maxNumber
                : (int) Math.Pow(10, maxNumberDigitsCount) - 1;

            var primeList = PrimeNumbersFinder.GetPrimeNumbers(primeLimit);
            var circularPrimeNumbersCount = CircularPrimeNumbersFinder.CalculateCircularPrimeNumbersCount(primeList, maxNumber);

            Console.WriteLine("There are {0} circular prime numbers below {1}", circularPrimeNumbersCount, maxNumber);
        }
    }
}
