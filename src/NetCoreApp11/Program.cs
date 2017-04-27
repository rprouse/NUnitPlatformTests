using System;

namespace NetCoreApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(int prime in 5.Primes())
            {
                Console.WriteLine(prime);
            }
        }
    }
}