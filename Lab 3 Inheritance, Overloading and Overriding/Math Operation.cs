using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Inheritance__Overloading_and_Overriding
{
    public class MathOperationOverloading
    {
        // Concept of Overloading
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
