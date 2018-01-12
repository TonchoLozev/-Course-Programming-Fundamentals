using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, List<double>>> dragons = new Dictionary<string, SortedDictionary<string, List<double>>>();
            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                var info = Console.ReadLine().Split(' ');
                string type = info[0];
                string dragonName = info[1];
                double dmg = 0;
                double health = 0;
                double armor = 0;
                if (info[2] == "null")
                {
                    dmg = 45;
                }
                else
                {
                    dmg = double.Parse(info[2]);
                }
                if (info[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = double.Parse(info[3]);
                }
                if (info[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = double.Parse(info[4]);
                }
                List<double> characteristics = new List<double> { dmg, health, armor };

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string, List<double>>());
                }
                if (!dragons[type].ContainsKey(dragonName))
                {
                    dragons[type].Add(dragonName, characteristics);
                }
                dragons[type][dragonName] = characteristics;
            }
            foreach (var dragon in dragons)
            {
                double averageDmg = dragon.Value.Select(x => x.Value[0]).Average();
                double averageHealtrh = dragon.Value.Select(x => x.Value[1]).Average();
                double averageArrmor = dragon.Value.Select(x => x.Value[2]).Average();

                Console.WriteLine($"{dragon.Key}::({averageDmg:F2}/{averageHealtrh:F2}/{averageArrmor:F2})");

                foreach (var currentDrag in dragon.Value)
                {
                    Console.WriteLine($"-{currentDrag.Key} -> damage: {currentDrag.Value[0]}, health: {currentDrag.Value[1]}, armor: {currentDrag.Value[2]}");
                }
            }
        }
    }
}
