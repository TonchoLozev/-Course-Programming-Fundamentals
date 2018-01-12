using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Armada
{
    class Soldiers
    {
        public int LastActivity { get; set; }
        public Dictionary<string, int> SoldierTypeAndCount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Soldiers> legionAndSoldiers = new Dictionary<string, Soldiers>(); //Dict to hold Legions and Soldiers

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

                int lastActivity = int.Parse(input[0].Trim());
                string legionName = input[1].Trim();
                string soldierType = input[2].Trim();
                int soldierCount = int.Parse(input[3].Trim());
                
                if (!legionAndSoldiers.ContainsKey(legionName))
                {
                    legionAndSoldiers.Add(legionName, new Soldiers());

                    legionAndSoldiers[legionName].SoldierTypeAndCount = new Dictionary<string, int>();

                    legionAndSoldiers[legionName].SoldierTypeAndCount.Add(soldierType, 0);
                    legionAndSoldiers[legionName].SoldierTypeAndCount[soldierType] += soldierCount;
                    legionAndSoldiers[legionName].LastActivity = lastActivity;
                }
                else
                {
                    if (!legionAndSoldiers[legionName].SoldierTypeAndCount.ContainsKey(soldierType))
                    {

                        legionAndSoldiers[legionName].SoldierTypeAndCount.Add(soldierType, 0);
                        legionAndSoldiers[legionName].SoldierTypeAndCount[soldierType] += soldierCount;

                        if (lastActivity > legionAndSoldiers[legionName].LastActivity)
                        {
                            legionAndSoldiers[legionName].LastActivity = lastActivity;
                        }
                    }
                    else
                    {
                        legionAndSoldiers[legionName].SoldierTypeAndCount[soldierType] += soldierCount;

                        if (lastActivity > legionAndSoldiers[legionName].LastActivity)
                        {
                            legionAndSoldiers[legionName].LastActivity = lastActivity;
                        }
                    }
                }
            }

            string[] infoToShow = Console.ReadLine().Split('\\');

            if (infoToShow.Length == 2)
            {
                int activity = int.Parse(infoToShow[0].Trim());
                string type = infoToShow[1].Trim();

                var belowType = legionAndSoldiers.Where(x => x.Value.LastActivity < activity).ToDictionary(x => x.Key, y => y.Value);

                if (belowType.Count > 0)
                {
                    foreach (var groupName in belowType.OrderByDescending(x => x.Value.SoldierTypeAndCount[type]).ToDictionary(x => x.Key, y => y.Value))
                    {
                        foreach (var item in groupName.Value.SoldierTypeAndCount)
                        {
                            if (item.Key == type)
                            {
                                Console.WriteLine($"{groupName.Key} -> {item.Value}");
                            }
                        }
                    }
                }
            }
            else if (infoToShow.Length == 1)
            {
                string type = infoToShow[0];

                foreach (var legion in legionAndSoldiers.OrderByDescending(x=>x.Value.LastActivity))
                {
                    if (legion.Value.SoldierTypeAndCount.ContainsKey(type)) ;
                    {
                        Console.WriteLine($"{legion.Value.LastActivity} : {legion.Key}");
                    }
                }
            }
        }
    }
}
