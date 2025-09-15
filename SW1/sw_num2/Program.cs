using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sw_num2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter currency in ($): ");
            string str = Console.ReadLine();
            string[] str2 = str.Split(',');

            double[] nums = new double[str2.Length];
            Console.WriteLine();
            Console.WriteLine("Dollar($)\tPhil Peso(P)\tJpn Yen (Y): ");
            for(int i = 0; i < nums.Length; i++)
            {
                double num = double.Parse(str2[i]);
                Console.WriteLine($"{num}\t        {converterD(num).peso}\t        {converterD(num).yen}");
            }
        }

        static (double peso, double yen) converterD(double dollar)
        {
            double peso = dollar * 57.17;
            double yen = dollar * 146.67;
            return (peso, yen);
        }
    }
}
