using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            int lengthCm = length * 100;
            double reminder = lengthCm % width;
            if (reminder == 0 || width == 0)
            {
                Console.WriteLine($"{lengthCm * width:F2}");
            }
            else
            {
                Console.WriteLine($"{(lengthCm * 100) / width:F2}%");
            }
        }
    }
}
