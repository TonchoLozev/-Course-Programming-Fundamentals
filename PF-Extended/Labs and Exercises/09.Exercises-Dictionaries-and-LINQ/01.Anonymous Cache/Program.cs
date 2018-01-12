using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Anonymous_Cache
{
    class DataSet
    {
        public List<string> Names { get; set; }
        public ulong TotalSize { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, DataSet> sets = new Dictionary<string, DataSet>();
            Dictionary<string, DataSet> cachedSets = new Dictionary<string, DataSet>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "thetinggoesskrra") { break; }

                string[] split = input.Split(new char[] { '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);          

                if (split.Length == 1)
                {
                    string dataSet = split[0].Trim();
                    sets.Add(dataSet, new DataSet());

                    if (cachedSets.ContainsKey(dataSet))
                    {
                        sets[dataSet].Names = new List<string>();
                        sets[dataSet].Names.AddRange(cachedSets[dataSet].Names);
                        sets[dataSet].TotalSize += cachedSets[dataSet].TotalSize;
                    }
                }
                else if (split.Length == 3)
                {
                    string name = split[0].Trim();
                    ulong totalSize = ulong.Parse(split[1].Trim());
                    string dataSet = split[2].Trim();

                    //DataSet data = new DataSet();
                    //data.Names = new List<string>();
                    //data.Names.Add(name);
                    //data.TotalSize += totalSize;

                    if (!sets.ContainsKey(dataSet))
                    {
                        if (cachedSets.ContainsKey(dataSet))
                        {
                            cachedSets[dataSet].Names.Add(name);
                            cachedSets[dataSet].TotalSize += totalSize;
                        }
                        else
                        {
                            cachedSets.Add(dataSet, new DataSet());
                            cachedSets[dataSet].Names = new List<string>();
                            cachedSets[dataSet].Names.Add(name);
                            cachedSets[dataSet].TotalSize += totalSize;
                            
                        }
                    }
                    else
                    {
                        if(sets[dataSet].Names == null)
                        {
                            sets[dataSet].Names = new List<string>();
                        }
                        sets[dataSet].Names.Add(name);
                        sets[dataSet].TotalSize += totalSize;
                    }
                }

            }
            if (sets.Count > 0)
            {
                foreach (var set in sets.OrderByDescending(x => x.Value.TotalSize))
                {
                    Console.WriteLine($"Data Set: {set.Key}, Total Size: {set.Value.TotalSize}");
                    foreach (var name in set.Value.Names)
                    {
                        Console.WriteLine($"$.{name}");
                    }
                    break;
                }
            }
        }
    }
}
