using System;
using System.Linq;

namespace ConsoleApp1
{
    public class ArraySum
    {
        public void SumArray(int[] arr)
        {
            int arraySum = arr.Sum();
            Console.WriteLine("Sum of array elements: " + arraySum);
        }
    }
}
