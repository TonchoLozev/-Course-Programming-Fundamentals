using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.CODE_Phoenix_Oscar_Romeo_November
{
    class Creature
    {
        public string Name { get; set; }
        public List<string> SquadMates { get; set; }
        public int Count { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Creature> creatures = new Dictionary<string, Creature>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Blaze it!") { break; }

                string[] split = Regex.Split(input, " -> ");

                string creature = split[0].Trim();
                string squadMate = split[1].Trim();

                if (creature == squadMate) { continue; }

                if (!creatures.ContainsKey(creature))
                {
                    creatures.Add(creature, new Creature());

                    creatures[creature].SquadMates = new List<string>();

                    creatures[creature].SquadMates.Add(squadMate);
                }
                else
                {
                    if (!creatures[creature].SquadMates.Contains(squadMate))
                    {
                        creatures[creature].SquadMates.Add(squadMate);
                    }
                    else
                    {
                        continue;
                    }
                }
            }


            foreach (var creature in creatures.OrderByDescending(x => x.Value.SquadMates.Count))
            {
                int count = 0;

                foreach (var mate in creature.Value.SquadMates)
                {
                    if (creatures.ContainsKey(mate))
                    {
                        if (!creatures[mate].SquadMates.Contains(creature.Key))
                        {
                            creatures[creature.Key].Count += 1;
                        }
                    }
                    else
                    {
                        creatures[creature.Key].Count += 1;
                    }
                }
            }

            foreach (var creature in creatures.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{creature.Key} : {creature.Value.Count}");
            }
        }
    }
}
