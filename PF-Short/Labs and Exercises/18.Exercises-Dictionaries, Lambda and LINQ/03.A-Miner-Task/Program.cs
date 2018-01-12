using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int counter = 0;
            string resource = "";

            while (true)
            {
                string current = Console.ReadLine();
                if (current == "stop")
                {
                    break;
                }
                counter++;
                if (counter % 2 != 0)
                {
                    if (!dict.ContainsKey(current))
                    {
                        dict[current] = 0;
                    }
                    resource = current;                  
                }
                else
                {
                    int value = int.Parse(current);
                    dict[resource] += value;
                }
              
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
