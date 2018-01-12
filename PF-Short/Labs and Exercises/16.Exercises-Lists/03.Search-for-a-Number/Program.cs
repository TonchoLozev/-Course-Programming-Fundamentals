using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] amountOfFunctions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> filtered = new List<int>();
            for (int take = 0; take < amountOfFunctions[0]; take++)
            {
                filtered.Add(arrayOfNumbers[take]);
            }
            for (int removing = 0; removing < amountOfFunctions[1]; removing++)
            {
                filtered.Remove(filtered[0]);
            }
            bool ifPresent = false;
            for (int ifNumberPresent = 0; ifNumberPresent < filtered.Count; ifNumberPresent++)
            {
                if (amountOfFunctions[2] == filtered[ifNumberPresent])
                {
                    ifPresent = true;
                    break;
                }
            }
            if (ifPresent == true)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
