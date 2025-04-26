using System;

namespace ConsoleApp1
{
    public class Swap
    {
        public void Swapfxn(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swap:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
