using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Inheritance__Overloading_and_Overriding
{
    public class Palindrome
    {
        public void checkPalindrome()
        {
            Console.Write("Enter the string to check the palindrome");
            string input = Console.ReadLine();
            string toCheck = input;
            char[] characterArray = toCheck.ToCharArray();
            Array.Reverse(characterArray);
            string reversedString = new string(characterArray);

            if (toCheck == reversedString)
            {
                Console.Write("Input is Palindorme");
            }
            else
            {
                Console.Write("Input is not a Palindrome");
            }
        }
    }
}
