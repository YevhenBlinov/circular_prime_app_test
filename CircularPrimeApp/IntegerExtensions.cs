using System;

namespace CircularPrimeApp
{
    public static class IntegerExtensions
    {
        public static int GetDigitsCount(this int number)
        {
            if (number >= 0) 
                return number.ToString().Length;
            return number.ToString().Length - 1;
        }

        public static bool IsPowerOfTen(this int number)
        {
            //We need %1 to make sure that result from Math.Log10 is an integer.
            if (number == 1) return false;
            return (Math.Log10(number)%1) == 0;
        }
    }
}
