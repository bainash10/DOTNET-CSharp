using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            PrintHelloName();
            Console.WriteLine("----------------------------------");

            Swap swapObj = new Swap();
            swapObj.Swapfxn(5, 10);
            Console.WriteLine("----------------------------------");

            LargestNumber largestObj = new LargestNumber();
            largestObj.FindLargest(10, 20, 15);
            Console.WriteLine("----------------------------------");

            EvenOdd evenOddObj = new EvenOdd();
            evenOddObj.CheckEvenOdd(7);
            Console.WriteLine("----------------------------------");

            SumNaturalNumbers sumObj = new SumNaturalNumbers();
            sumObj.CalculateSum(10);
            Console.WriteLine("----------------------------------");

            LeapYear leapYearObj = new LeapYear();
            leapYearObj.CheckLeapYear(2024);
            Console.WriteLine("----------------------------------");

            ArraySum arraySumObj = new ArraySum();
            arraySumObj.SumArray(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("----------------------------------");

            Factorial factorialObj = new Factorial();
            factorialObj.CalculateFactorial(5);
            Console.WriteLine("----------------------------------");

            PrimeCheck primeObj = new PrimeCheck();
            primeObj.CheckPrime(17);
            Console.WriteLine("----------------------------------");

            Console.ReadKey();
        }

        static void PrintHelloName()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Nischal Baidar"); 
        }
    }
}
