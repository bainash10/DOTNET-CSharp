using Lab_3_Inheritance__Overloading_and_Overriding;

internal class Program
{
    private static void Main(string[] args)
    {
        MathOperationOverloading mathOperation = new MathOperationOverloading();
        int addvalue = mathOperation.Add(2, 6);
        double addedvalue = mathOperation.Add(12.5, 14.7);
        int product = mathOperation.Multiply(6, 4);
        double decimal_product = mathOperation.Multiply(17.02, 98.5);
        Console.WriteLine($"The int type add value is {addvalue}");
        Console.WriteLine($"The doubleint type add value is {addedvalue}");
        Console.WriteLine($"The multiply type add value is {product}");
        Console.WriteLine($"The doublemultiply type add value is {decimal_product}");

        Console.ReadKey();
        Console.Clear();

        MathOperationsInherit inheritance = new MathOperationsInherit();
        double add = inheritance.Add(5.5, 5);
        double sub = inheritance.Subtract(7, 3);
        double mul = inheritance.Multiply(4.5, 4);
        double div = inheritance.Divide(2, 2.5);
        Console.WriteLine($"Add = {add}, Subtract = {sub}, Multiply = {mul}, Divide = {div}");

        Console.ReadKey();
        Console.Clear();

        Palindrome checkingPalindrome = new Palindrome();
        checkingPalindrome.checkPalindrome();

        Console.ReadKey();
        Console.Clear();

    }
}