using System;
using System.Collections.Generic;

namespace CircularPrimeApp
{
    public static class PrimeNumbersFinder
    {
        public static HashSet<int> GetPrimeNumbers(int maxNumber)
        {
            //All prime numbers found by Eratosthenes' method: https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes 
            var primeBoolList = new List<bool>() { false, false };

            for (var i = 2; i < maxNumber; i++)
            {
                primeBoolList.Add(true);
            }

            for (var i = 2; (int)Math.Pow(i, 2) <= maxNumber; i++)
            {
                if (!primeBoolList[i]) continue;

                for (var j = (int)Math.Pow(i, 2); j < maxNumber; j += i)
                {
                    primeBoolList[j] = false;
                }
            }

            var primeIntList = new HashSet<int>();

            for (var i = 0; i < maxNumber; i++)
            {
                if (primeBoolList[i]) primeIntList.Add(i);
            }

            return primeIntList;
        }
    }
}
