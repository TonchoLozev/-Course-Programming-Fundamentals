using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            List<decimal> allSum = new List<decimal>();
            for (int i = 0; i < input.Length; i++)
            {
                string combination = input[i];
                decimal digit = decimal.Parse(combination.Substring(1, combination.Length - 2));
                char firstLetter = combination.First();
                char lastLetter = combination.Last();

                decimal first = 0; decimal sumFirst = 0;
                decimal second = 0; decimal sumSecond = 0;

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    first = firstLetter - 64;
                    sumFirst = digit / first;

                }
                else if (firstLetter >= 97 && firstLetter <= 122)
                {
                    first = firstLetter - 96;
                    sumFirst = digit * first;

                }
                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    second = lastLetter - 64;
                    sumSecond = sumFirst - second;

                }
                else if (lastLetter >= 97 && lastLetter <= 122)
                {
                    second = lastLetter - 96;
                    sumSecond = sumFirst + second;

                }
                allSum.Add(sumSecond);
            }
            decimal sum = 0;
            foreach (var item in allSum)
            {
                sum += item;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
