using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreApp11
{
    public static class PrimeNumbers
    {
        /// <summary>
        /// Returns a sequence of prime numbers
        /// </summary>
        /// <param name="num">The number of primes to return</param>
        /// <returns></returns>
        public static IEnumerable<int> Primes(this int num)
        {
            if (num < 0)
                throw new ArgumentException("Must be greater than or equal to zero", nameof(num));

            if (num == 0)
                yield break;

            yield return 2;
            if (num == 1)
                yield break;

            uint numReturned = 1;

            List<int> found = new List<int>();
            found.Add(3);
            int candidate = 3;
            while (numReturned < num)
            {
                bool isPrime = true;
                foreach (int prime in found)
                {
                    if (prime * prime > candidate)
                    {
                        break;
                    }
                    if (candidate % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    numReturned++;
                    found.Add(candidate);
                    yield return candidate;
                }
                candidate += 2;
            }
        }
    }
}
