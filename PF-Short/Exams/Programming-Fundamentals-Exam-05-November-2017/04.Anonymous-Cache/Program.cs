using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Anonymous_Cache
{
    class DataSet
    {
        public List<string> DataKeys { get; set; }
        public ulong TotalSize { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, DataSet> originalDataSets = new Dictionary<string, DataSet>();
            Dictionary<string, DataSet> cachedDataSets = new Dictionary<string, DataSet>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "thetinggoesskrra") { break; }

                string[] split = input.Split(' ');

                if (split.Length == 1)
                {
                    string dataSet = split[0].Trim();

                    if (cachedDataSets.ContainsKey(dataSet))
                    {
                        originalDataSets.Add(dataSet, new DataSet());
                        originalDataSets[dataSet].DataKeys = new List<string>();

                        originalDataSets[dataSet] = cachedDataSets[dataSet];
                    }
                    else
                    {
                        originalDataSets.Add(dataSet, new DataSet());
                        originalDataSets[dataSet].DataKeys = new List<string>();
                    }                                 
                }
                else
                {
                    string dataKey = split[0].Trim();
                    int dataSize = int.Parse(split[2].Trim());
                    string dataSet = split[4].Trim();

                    if (!originalDataSets.ContainsKey(dataSet))
                    {
                        if (!cachedDataSets.ContainsKey(dataSet))
                        {
                            cachedDataSets.Add(dataSet, new DataSet());

                            cachedDataSets[dataSet].DataKeys = new List<string>();

                            cachedDataSets[dataSet].DataKeys.Add(dataKey);
                            cachedDataSets[dataSet].TotalSize += (ulong)dataSize;
                        }
                        else
                        {
                            cachedDataSets[dataSet].DataKeys.Add(dataKey);
                            cachedDataSets[dataSet].TotalSize += (ulong)dataSize;
                        }
                    }
                    else
                    {
                        originalDataSets[dataSet].DataKeys.Add(dataKey);
                        originalDataSets[dataSet].TotalSize += (ulong)dataSize;
                    }
                }
            }

            foreach (var dataSet in originalDataSets.OrderByDescending(x=>x.Value.TotalSize))
            {
                Console.WriteLine($"Data Set: {dataSet.Key}, Total Size: {dataSet.Value.TotalSize}");
                foreach (var dataKey in dataSet.Value.DataKeys)
                {
                    Console.WriteLine($"$.{dataKey}");
                }
                break;
            }
        }
    }
}
