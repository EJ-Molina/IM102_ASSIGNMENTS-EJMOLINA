using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sw_num1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String: ");
            String str = Console.ReadLine();
            Console.WriteLine();
            checkPrime(str);
            Console.ReadKey();
        }

        static void checkPrime(String str)
        {
            string[] str1 = str.Split(' ');
            int[] nums = new int[str1.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(str1[i]);

                bool isPrime = true;
                int num = nums[i]; 
                int div = 2;
                if (num < 2)
                {
                    isPrime = false;
                }
                else{
                    while (div < num)
                    {
                        if (num % div == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        div++;
                    }
                }

                Console.WriteLine($"{i + 1}. {nums[i]}\t {(isPrime ? "Prime" : "Composite")}");
            }
        }
    }
}
