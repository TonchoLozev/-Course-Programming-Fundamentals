using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            double[] zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (string driver in names)
            {
                int couunter = 0;
                double fuel = driver[0];
                for (int i = 0; i < zones.Length; i++)
                {                   
                    if (checkpoints.Any(x => x == i))
                    {
                        fuel += zones[i];
                    }
                    else
                    {
                        fuel -= zones[i];
                    }
                    if (fuel <= 0)
                    { break; }
                    couunter++;
                }
                if (fuel <= 0)
                {
                    Console.WriteLine($"{driver} - reached {couunter}");
                }
                else
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:F2}");
                }
            }
        }
    }
}
