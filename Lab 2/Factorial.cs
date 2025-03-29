using System;

namespace ConsoleApp1
{
    public class Factorial
    {
        public void CalculateFactorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
                factorial *= i;
            Console.WriteLine("Factorial of " + num + " is " + factorial);
        }
    }
}
