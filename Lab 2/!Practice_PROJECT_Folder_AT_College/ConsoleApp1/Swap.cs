using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LargestNumber
    {
        public void FindLargest(int x, int y, int z)
        {
            int largest = (x > y) ? ((x > z) ? x : z) : ((y > z) ? y : z);
            Console.WriteLine("Largest Number: " + largest);
        }
    }
}
