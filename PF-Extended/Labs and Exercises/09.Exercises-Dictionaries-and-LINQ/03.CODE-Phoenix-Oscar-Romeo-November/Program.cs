using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.CODE_Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Blaze it!") { break; }

                string[] split = Regex.Split(input, " -> ");

                string creature = split[0].Trim();
                string squadMate = split[1].Trim();

                if (!dict.ContainsKey(creature))
                {
                    dict.Add(creature, new List<string>());
                    dict[creature].Add(squadMate);
                }
                else
                {
                    if (!dict[creature].Equals(squadMate))
                    {
                        if (!dict[creature].Contains(squadMate))
                        {
                            dict[creature].Add(squadMate);
                        }
                    }
                }
            }

            //foreach (var creature in dict.OrderByDescending(x => x.Value.Count))
            //{
            //    int count = 0;
            //    foreach (var mate in creature.Value)
            //    {
            //        if (dict.ContainsKey(mate) && dict[mate].Contains(creature.Key))
            //        {

            //        }
            //        else
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine($"{creature.Key} : {count}");
            //}

            var result = new Dictionary<string, List<string>>();

            foreach (var creature in dict)
            {
                result.Add(creature.Key, new List<string>());

                foreach (var mate in creature.Value)
                {
                    if (dict.ContainsKey(mate) && dict[mate].Contains(creature.Key))
                    {

                    }
                    else
                    {
                        result[creature.Key].Add(mate);
                    }
                }
            }
            foreach (var creature in result.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{creature.Key} : {creature.Value.Count}");
            }
        }
    }
}
