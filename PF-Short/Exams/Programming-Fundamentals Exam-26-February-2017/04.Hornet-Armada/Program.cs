using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class Soldier
    {
        public long LastActivity { get; set; }
        public string LegionName { get; set; }
        public Dictionary<string, long> SoldierTypeAndCount { get; set; }
        public long SoldierCount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Soldier> info = new Dictionary<string, Soldier>();

            ushort n = ushort.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] splitInpuit = Regex.Split(input, " -> ");
                string[] firistPart = splitInpuit[0].Split('=');
                string[] secondPart = splitInpuit[1].Split(':');

                long lastActivity = long.Parse(firistPart[0]);
                string legionName = firistPart[1].Trim();
                string soldierType = secondPart[0];
                long soldierCount = long.Parse(secondPart[1]);
                if(legionName.Contains('=')|| legionName.Contains('-')||legionName.Contains('>')|| legionName.Contains(':')|| legionName.Contains(' '))
                {
                    continue;
                }
                if (soldierType.Contains('=') || soldierType.Contains('-') || soldierType.Contains('>') || soldierType.Contains(':') || soldierType.Contains(' '))
                {
                    continue;
                }
                if (!info.ContainsKey(legionName))
                {
                    info.Add(legionName, new Soldier());
                    info[legionName].SoldierTypeAndCount = new Dictionary<string, long>();

                    info[legionName].LastActivity = lastActivity;
                    info[legionName].LegionName = legionName;
                    info[legionName].SoldierTypeAndCount.Add(soldierType,soldierCount);
                    info[legionName].SoldierCount = soldierCount;
                }
                else if (info.ContainsKey(legionName))
                {
                    if (!info[legionName].SoldierTypeAndCount.ContainsKey(soldierType))
                    {
                        info[legionName].SoldierTypeAndCount.Add(soldierType,soldierCount);
                        info[legionName].SoldierCount += soldierCount;
                        if (info[legionName].LastActivity < lastActivity)
                        {
                            info[legionName].LastActivity = lastActivity;
                        }
                    }
                    else if (info[legionName].SoldierTypeAndCount.ContainsKey(soldierType))
                    {
                        info[legionName].SoldierTypeAndCount[soldierType] += soldierCount;
                        info[legionName].SoldierCount += soldierCount;

                        if (info[legionName].LastActivity < lastActivity)
                        {
                            info[legionName].LastActivity = lastActivity;
                        }
                    }
                }
            }
            string whatInfoToShow = Console.ReadLine();
            string[] split = whatInfoToShow.Split('\\');
            long activity = 0;
            string soldierTyp = "";
            if (split.Length == 2)
            {
                activity = long.Parse(split[0]);
                soldierTyp = split[1];
                foreach (var legion in info.OrderByDescending(x=>x.Value.SoldierCount))
                {
                    if(legion.Value.SoldierTypeAndCount.Keys.Contains(soldierTyp)&&legion.Value.LastActivity<activity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legion.Value.SoldierTypeAndCount[soldierTyp]}");
                    }
                }
            }
            else
            {
                soldierTyp = split[0];
                foreach (var legion in info.OrderByDescending(x=>x.Value.LastActivity))
                {
                    if(legion.Value.SoldierTypeAndCount.Keys.Contains(soldierTyp))
                    {
                        Console.WriteLine($"{legion.Value.LastActivity} : {legion.Key}");
                    }
                }
            }
        }
    }
}
