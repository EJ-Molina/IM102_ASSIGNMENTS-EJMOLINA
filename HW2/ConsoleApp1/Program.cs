using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter col: ");
            int col = int.Parse(Console.ReadLine());

            //List<double> nums = new List<double>();
            List<List<double>> nums = new List<List<double>>();

            for (int i = 0; i < row; i++)
            {
                Console.WriteLine($"Row {i + 1}");
                nums.Add(new List<double>{ });
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Enter number {j+1}: ");
                    nums[i].Add(double.Parse(Console.ReadLine()));
                }
                Console.WriteLine();
            }


            double sum = 0;
            int ave = 0;
            Console.WriteLine("The numbers are: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{(nums[i][j]).ToString("F1")} ");
                    sum += nums[i][j];
                    ave++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum.ToString("F2")}");
            Console.WriteLine($"Average: {(sum / ave).ToString("F2")}");
            Console.ReadKey();
        }
    }
}
