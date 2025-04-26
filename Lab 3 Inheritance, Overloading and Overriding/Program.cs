using System;
using Lab_3_Inheritance__Overloading_and_Overriding;

internal class Program
{
    private static void Main(string[] args)
    {

        // Overriding
        Console.WriteLine("=== Overriding (Inheritance + Overriding) ===");

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nSelect Operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("\nEnter your choice (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Operation operation = null;

        switch (choice)
        {
            case 1:
                operation = new Addition();
                break;
            case 2:
                operation = new Subtraction();
                break;
            case 3:
                operation = new Multiplication();
                break;
            case 4:
                operation = new Division();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        try
        {
            double result = operation.Calculate(num1, num2);
            Console.WriteLine($"\nResult: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
        Console.Clear();

        // Method Overloading
        MathOperationOverloading mathOperation = new MathOperationOverloading();
        int addvalue = mathOperation.Add(2, 6);
        double addedvalue = mathOperation.Add(12.5, 14.7);
        int product = mathOperation.Multiply(6, 4);
        double decimal_product = mathOperation.Multiply(17.02, 98.5);

        Console.WriteLine("=== Method Overloading ===");
        Console.WriteLine($"The int type add value is {addvalue}");
        Console.WriteLine($"The double type add value is {addedvalue}");
        Console.WriteLine($"The int multiply value is {product}");
        Console.WriteLine($"The double multiply value is {decimal_product}");

        Console.ReadKey();
        Console.Clear();

        // Inheritance
        MathOperationsInherit inheritance = new MathOperationsInherit();
        double add = inheritance.Add(5.5, 5);
        double sub = inheritance.Subtract(7, 3);
        double mul = inheritance.Multiply(4.5, 4);
        double div = inheritance.Divide(2, 2.5);

        Console.WriteLine("=== Inheritance ===");
        Console.WriteLine($"Add = {add}, Subtract = {sub}, Multiply = {mul}, Divide = {div}");

        Console.ReadKey();
        Console.Clear();

        // Palindrome Checking
        Palindrome checkingPalindrome = new Palindrome();
        Console.WriteLine("=== Palindrome Check ===");
        checkingPalindrome.checkPalindrome();

        Console.ReadKey();
        Console.Clear();

        
    }
}
