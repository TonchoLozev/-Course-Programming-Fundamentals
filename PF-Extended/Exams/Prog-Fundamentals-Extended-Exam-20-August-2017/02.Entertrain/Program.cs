using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());

            List<int> wagons = new List<int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "All ofboard!") { break; }

                int weight = int.Parse(input.Trim());

                wagons.Add(weight);

                if (wagons.Sum() > power)
                {
                    int totalWeight = wagons.Sum();

                    int average = totalWeight / wagons.Count;

                    int closest = wagons.OrderBy(item => Math.Abs(average - item)).First();

                    wagons.Remove(closest);
                }
            }

            wagons.Reverse();
            wagons.Add(power);

            Console.WriteLine(string.Join(" ", wagons));

        }
    }
}
