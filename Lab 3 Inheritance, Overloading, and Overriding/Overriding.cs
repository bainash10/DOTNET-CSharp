namespace Lab_3_Inheritance__Overloading_and_Overriding
{
    public class Operation
    {
        public virtual double Calculate(double a, double b)
        {
            return 0;
        }
    }

    public class Addition : Operation
    {
        public override double Calculate(double a, double b)
        {
            return a + b;
        }
    }

    public class Subtraction : Operation
    {
        public override double Calculate(double a, double b)
        {
            return a - b;
        }
    }

    public class Multiplication : Operation
    {
        public override double Calculate(double a, double b)
        {
            return a * b;
        }
    }

    public class Division : Operation
    {
        public override double Calculate(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }
    }
}
