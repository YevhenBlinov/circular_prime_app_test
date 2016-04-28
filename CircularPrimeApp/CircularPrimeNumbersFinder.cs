using System.Collections.Generic;
using System.Linq;

namespace CircularPrimeApp
{
    public static class CircularPrimeNumbersFinder
    {
        public static int CalculateCircularPrimeNumbersCount(HashSet<int> primeList, int maxNumber)
        {
            var circularPrimeList = new HashSet<int>();

            foreach (var prime in primeList)
            {
                if(prime > maxNumber) break;

                if (!CanBeCircularPrime(prime)) continue;

                if (circularPrimeList.Contains(prime)) continue;

                var digitsCount = prime.GetDigitsCount();
                var circularCandidates = new List<int> { prime };
                var potentialCircular = prime;

                for (var i = 0; i < digitsCount; i++)
                {
                    potentialCircular = RotatePrime(potentialCircular);

                    //Verification of this condition is necessary in order not to miss numbers, which consists of the same digits,
                    //for example 11.
                    if (digitsCount > 1 && i == 0 && potentialCircular == prime)
                    {
                        circularCandidates.Add(potentialCircular);
                    }

                    if (potentialCircular != prime && primeList.Contains(potentialCircular))
                    {
                        circularCandidates.Add(potentialCircular);
                    }
                }

                if (digitsCount != circularCandidates.Count) continue;

                var candidates = circularCandidates.Where(circularCandidate => circularCandidate < maxNumber);
                foreach (var circularCandidate in candidates)
                {
                    circularPrimeList.Add(circularCandidate);
                }
            }

            return circularPrimeList.Count;
        }

        private static bool CanBeCircularPrime(int prime)
        {
            if (prime == 2 || prime == 5) 
                return true;

            while (prime > 0)
            {
                var digit = prime % 10;
                if (digit % 2 == 0 || digit == 5) 
                    return false;
                prime /= 10;
            }

            return true;
        }

        private static int RotatePrime(int prime)
        {
            if (prime < 10) 
                return prime;
            var potentialPrime = 0;
            var multiplier = 10;

            while (prime > 9)
            {
                potentialPrime += (prime % 10) * multiplier;
                multiplier *= 10;
                prime /= 10;
            }

            potentialPrime += prime % 10;
            return potentialPrime;
        }
    }
}
