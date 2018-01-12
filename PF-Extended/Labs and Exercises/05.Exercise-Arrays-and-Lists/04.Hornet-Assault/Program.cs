using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bees = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] hornets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long hornetsPower = hornets.Sum();
         
            List<int> hornetsAction = hornets.ToList();
            for (int i = 0; i < bees.Length; i++)
            {
                if(hornetsAction.Count == 0) { break; }

                if(hornetsPower > bees[i])
                {
                    bees[i] = 0;
                }
                else if (hornetsPower == bees[i])
                {
                    bees[i] = 0;
                    hornetsPower -= hornetsAction[0];
                    hornetsAction.RemoveAt(0);
                }
                else if (hornetsPower < bees[i])
                {
                    bees[i] -= (int)hornetsPower;
                    hornetsPower -= hornetsAction[0];
                    hornetsAction.RemoveAt(0);
                }
            }

            List<int> beesAction = new List<int>();

            if (bees.Any(x => x > 0))
            {
                for (int i = 0; i < bees.Length; i++)
                {
                    if (bees[i] != 0)
                    {
                        beesAction.Add(bees[i]);
                    }
                }
                Console.WriteLine(string.Join(" ",beesAction));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornetsAction));
            }
        }
    }
}
