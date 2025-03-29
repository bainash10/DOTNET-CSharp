using System;

namespace ConsoleApp1
{
    public class EvenOdd
    {
        public void CheckEvenOdd(int num)
        {
            Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
        }
    }
}
