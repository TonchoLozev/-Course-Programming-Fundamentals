using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList(); //readLine
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();  //readLine
            List<long> beehivesCopy = new List<long>(beehives);     //To Calculate
            List<long> hornetsCopy = new List<long>(hornets);       //To Calculate

            long sumPower = hornets.Sum();
          
            int counter = 0;
            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0) { break; }

                if (sumPower > beehives[i])
                {
                    beehivesCopy.Remove(beehivesCopy[counter]);
                    counter--;
                }
                else if (sumPower == beehives[i])
                {
                    hornetsCopy.Remove(hornetsCopy.First());
                    beehivesCopy.Remove(beehivesCopy[counter]);
                    sumPower = hornetsCopy.Sum();
                    counter--;
                }
                else if (sumPower < beehives[i])
                {
                    hornetsCopy.Remove(hornetsCopy.First());
                    beehivesCopy[counter] -= sumPower ;
                    sumPower = hornetsCopy.Sum();
                }
                counter++;
            }
            if (beehivesCopy.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehivesCopy));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornetsCopy));
            }          
        }
    }
}
