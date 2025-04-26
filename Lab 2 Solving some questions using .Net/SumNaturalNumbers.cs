using System;

namespace ConsoleApp1
{
    public class SumNaturalNumbers
    {
        public void CalculateSum(int n)
        {
            int sum = n * (n + 1) / 2;
            Console.WriteLine("Sum of first " + n + " natural numbers: " + sum);
        }
    }
}
