using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfRegions = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());

            decimal sum = 0;
            for (int i = 0; i < amountOfRegions; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                long raindropsCount = long.Parse(input[0].Trim());
                int squareMeter = int.Parse(input[1].Trim());

                decimal calculation = (decimal)raindropsCount / (decimal)squareMeter;

                sum += calculation;
            }

            if (sum == 0 || density == 0)
            {
                Console.WriteLine(sum);
            }
            else
            {
                decimal n = sum / density;
                Console.WriteLine($"{n:F3}");
            }
        }
    }
}
