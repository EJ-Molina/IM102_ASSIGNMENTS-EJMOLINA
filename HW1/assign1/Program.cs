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
