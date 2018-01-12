using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {

            int amount = int.Parse(Console.ReadLine());

            for (int i = 0; i < amount; i++)
            {
                long totalLength = long.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                long wingLength = long.Parse(Console.ReadLine());

                decimal totalYears = (decimal)Math.Pow(totalLength, 2) * (totalWidth + (2 * wingLength));

                Console.WriteLine($"{totalYears}");
            }

        }
    }
}
