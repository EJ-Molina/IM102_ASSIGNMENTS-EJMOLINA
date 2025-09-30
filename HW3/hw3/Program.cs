using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<char, int>> wordFreq = new List<Dictionary<char, int>> { };
            Console.Write("Enter String: ");
            string str = Console.ReadLine().ToLower();
            string[] word = str.Split(' ');
            

            for(int i = 0; i < word.Length; i++)
            {
                string nWord = word[i];
                wordFreq.Add(new Dictionary<char, int>());
                foreach (char s in nWord)
                {
                    if (char.IsLetterOrDigit(s))
                    {
                        wordFreq[i][s] = (wordFreq[i].ContainsKey(s) ? wordFreq[i][s] : 0) + 1;
                    }
                }

            }

            foreach(var item in wordFreq)
            {
                var freqArr = item.Select((kv) => $"{kv.Key}={kv.Value}");
                string output = string.Join(",", freqArr);
                Console.WriteLine(output);
            }

        }
    }
}
