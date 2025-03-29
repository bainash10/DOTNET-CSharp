using System;

namespace ConsoleApp1
{
    public class PrimeCheck
    {
        public void CheckPrime(int primeNum)
        {
            bool isPrime = primeNum > 1;
            for (int i = 2; i <= Math.Sqrt(primeNum); i++)
            {
                if (primeNum % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(primeNum + " is " + (isPrime ? "a Prime Number" : "Not a Prime Number"));
        }
    }
}
