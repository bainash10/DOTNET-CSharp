using System;

namespace ConsoleApp1
{
    public class LeapYear
    {
        public void CheckLeapYear(int year)
        {
            Console.WriteLine((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) ? "Leap Year" : "Not a Leap Year");
        }
    }
}
