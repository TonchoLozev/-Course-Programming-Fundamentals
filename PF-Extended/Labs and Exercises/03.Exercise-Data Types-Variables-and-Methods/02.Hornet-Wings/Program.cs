using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distanceMeters = (wingFlaps / 1000) * distance;
            int flapsSecond = wingFlaps / 100;
            double rest = (wingFlaps / endurance) * 5;
            double sum = rest + flapsSecond;
            Console.WriteLine($"{distanceMeters:F2} m.");
            Console.WriteLine($"{sum} s.");
        }
    }
}
