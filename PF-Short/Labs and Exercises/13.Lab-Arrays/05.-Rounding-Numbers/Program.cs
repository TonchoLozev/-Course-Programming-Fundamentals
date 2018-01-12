using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] n = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i <= n.Length-1; i++)
            {
                double roundedNumber = Math.Round(n[i],0,MidpointRounding.AwayFromZero);

                Console.WriteLine($"{n[i]} => {roundedNumber}");
            }
        }
    }
}
