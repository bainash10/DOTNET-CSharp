using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Swap
    {
        public void Swapfxn(int a, int b) {
            
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
        
    }
}
