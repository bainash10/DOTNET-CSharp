using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {

        ////string input = Console.ReadLine();  //Default value is taken as string
        //int number = Convert.ToInt32(Console.ReadLine());
        ////Console.WriteLine("The input is :" + input);
        //Console.WriteLine(number);

        //string[] 
        //Console.ReadKey(); // Like getch() in c programming


        //Swapping
        //int a = 5;
        //int b = 6;
        //int temp;
        //temp = a;
        //a = b;
        //b = temp;
        //Console.WriteLine(a);
        //Console.WriteLine(b);

        //Largest of three numbers
        //int n1 = Convert.ToInt32(Console.ReadLine());
        //int n2 = Convert.ToInt32(Console.ReadLine());
        //int n3 = Convert.ToInt32(Console.ReadLine());
        //if (n1 > n2 && n1 > n3)
        //{
        //    Console.WriteLine("n1 is the greatest");
        //}
        //else if (n2 > n1 && n2 > n3)
        //{
        //    Console.WriteLine("n2 is the greatest");
        //}
        //else
        //{
        //    Console.WriteLine("n3 is the greatest");
        //}

        //Checking even or odd
        //int n1 = Convert.ToInt32(Console.ReadLine());

        //if (n1 % 2==0)
        //{
        //    Console.WriteLine("n1 is the even");
        //}
        //else
        //{
        //    Console.WriteLine("n1 is odd");
        //}

        //Swapping
        //int a = 5;
        //int b = 6;
        //Swap swapv = new Swap();
        //swapv.Swapfxn(a, b);

        //Sum of n natural number
        //int n1 = Convert.ToInt32(Console.ReadLine());
        //int sum = 0;
        //for (int i = 1; i <= n1; i++)
        //{
        //    sum=sum+i;
        //    //i++;
        //}
        //Console.WriteLine("Sum of n natural number is " + i);
        //Console.ReadKey();

        //Factorial
        //int n1 = Convert.ToInt32(Console.ReadLine());
        //int sum = 1;
        //for (int i = 1; i <= n1; i++)
        //{
        //    sum = sum * i;
        //    //i++;
        //}
        //Console.WriteLine("Factorial of the number is " + sum);
        //Console.ReadKey();

        //Leap year
        //A year is a leap year if:
        //It is divisible by 4 AND
        //It is NOT divisible by 100, unless also divisible by 400
        //Console.Write("Enter a year: ");
        //int year = Convert.ToInt32(Console.ReadLine());

        //if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        //{
        //    Console.WriteLine($"{year} is a Leap Year.");
        //}
        //else
        //{
        //    Console.WriteLine($"{year} is NOT a Leap Year.");
        //}

        Swap swapObj = new Swap();
        swapObj.Swapfxn(5, 10);

        LargestNumber largestObj = new LargestNumber();
        largestObj.FindLargest(10, 20, 15);

        EvenOdd evenOddObj = new EvenOdd();
        evenOddObj.CheckEvenOdd(7);

        SumNaturalNumbers sumObj = new SumNaturalNumbers();
        sumObj.CalculateSum(10);

        LeapYear leapYearObj = new LeapYear();
        leapYearObj.CheckLeapYear(2024);

        ArraySum arraySumObj = new ArraySum();
        arraySumObj.SumArray(new int[] { 1, 2, 3, 4, 5 });

        Factorial factorialObj = new Factorial();
        factorialObj.CalculateFactorial(5);

        PrimeCheck primeObj = new PrimeCheck();
        primeObj.CheckPrime(17);

        Console.ReadKey();

    }
}