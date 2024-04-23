using System;

namespace FactorialLibrary
{
    public static class Factorial
    {
        public static long Calculate(long n)
        {

            if (n <= 1)
            {
                return 1;
            }

            long result = 1;

            for (int i = 2; i <= n; i++)
            {
                {
                    result = result*i;
                }
            }

            return result;
        }
    }
}
