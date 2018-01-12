using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string first = input[0];
            string second = input[1];
            int sum = 0;
            for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
            {
                sum += first[i] * second[i];
            }
            for (int i = Math.Max(first.Length, second.Length)-1; i >= Math.Min(first.Length, second.Length); i--)
            {
                if (first.Length > second.Length)
                {
                    sum += first[i];
                }
                else
                {
                    sum += second[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
