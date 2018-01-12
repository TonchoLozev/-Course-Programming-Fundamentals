using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Splinter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double distnaceMiles = double.Parse(Console.ReadLine());
            double tankCapacityLiters = double.Parse(Console.ReadLine());
            double mileInHaevyWinds = double.Parse(Console.ReadLine());

            double milesInNonHaevyWinds = distnaceMiles - mileInHaevyWinds;

            double nonHaveyWindsConsumption = milesInNonHaevyWinds * 25;
            double haveyMilesConsumption = mileInHaevyWinds * (25 * 1.5);

            double fuelConsuption = nonHaveyWindsConsumption + haveyMilesConsumption;
            double tolerance = (fuelConsuption * 5) / 100;

            double totalFuelConsumption = fuelConsuption + tolerance;

            Console.WriteLine($"Fuel needed: {totalFuelConsumption:F2}L");

            double sum = tankCapacityLiters - totalFuelConsumption;

            if (tankCapacityLiters >= totalFuelConsumption)
            {
                Console.WriteLine($"Enough with {sum:F2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {Math.Abs(sum):F2}L more fuel.");
            }
        }
    }
}
