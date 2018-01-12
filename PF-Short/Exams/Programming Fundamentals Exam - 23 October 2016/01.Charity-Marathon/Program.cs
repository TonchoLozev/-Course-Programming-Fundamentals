using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            uint days = uint.Parse(Console.ReadLine());
            uint runners = uint.Parse(Console.ReadLine());
            uint averageLaps = uint.Parse(Console.ReadLine());
            uint length = uint.Parse(Console.ReadLine());
            uint capacity = uint.Parse(Console.ReadLine());
            decimal money = decimal.Parse(Console.ReadLine());
            uint total = 0;
            uint daysForCycle = days;
            while (daysForCycle >= 1)
            {
                if (runners <= 0)
                {
                    break;
                }
                else
                {
                    if (runners >= capacity)
                    {
                        runners -= capacity;
                        total += capacity;
                    }
                    else
                    {
                        total += runners;
                    }
                }
                daysForCycle--;
            }

            uint totalMeters = (total * averageLaps) * length;
            uint totalKm = totalMeters / 1000;
            decimal moneyForTheMarathong = totalKm * money;
            Console.WriteLine($"Money raised: {moneyForTheMarathong:F2}");
        }
    }
}
