using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a console - based program that repeatedly accepts a string
              and determine whether the string is a PALINDROME or NOT.
              A palindrome is a string when reversed is the same as the original string.
            Example civic, RACECAR, level, madam is a PALINDROME. If the user types, asterisk *
            the loop will terminate and display the output
            (original and reversed string and palindrome or not) thereafter.
            Never use a C# built-in method but you can only use .ToLower() method.*/


            while (true)
            {
                Console.Write("Enter string: ");
                string str = Console.ReadLine().ToLower();
                if(str == "*")
                {
                    break;
                }

                string rStr = "";
                for(int i = str.Length -1; i >= 0; i--)
                {
                    rStr += str[i];
                }

                bool isPal = true;
                if(str == rStr)
                {
                    isPal = true;
                }
                else
                {
                    isPal = false;
                }
                Console.WriteLine("Original String         Reversed String            Palindrome?");
                Console.WriteLine($"   {str}                    {rStr}                     {(isPal ? "Yes" : "No")}");
                Console.WriteLine();
            }
 
        }
    }
}
