using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainlands
{
    class Train
    {
        public string Name { get; set; }
        public Dictionary<string, int> WagonsNameAndPower { get; set; }
        public ulong SumWagonPower { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Train> trains = new Dictionary<string, Train>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "It's Training Men!") { break; }

                string[] split = input.Split(' ');

                //Adding trains 

                //First Condition(command)
                if (split.Length == 5)
                {
                    string trainName = split[0].Trim();
                    string wagonName = split[2].Trim();
                    int wagonPower = int.Parse(split[4].Trim());

                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Train());
                        trains[trainName].Name = trainName;

                        trains[trainName].WagonsNameAndPower = new Dictionary<string, int>();

                        trains[trainName].WagonsNameAndPower.Add(wagonName, 0);
                        trains[trainName].WagonsNameAndPower[wagonName] += wagonPower;

                        trains[trainName].SumWagonPower += (ulong)wagonPower;
                    }

                    else
                    {
                        trains[trainName].WagonsNameAndPower.Add(wagonName, 0);
                        trains[trainName].WagonsNameAndPower[wagonName] += wagonPower;

                        trains[trainName].SumWagonPower += (ulong)wagonPower;
                    }
                }

                else
                {
                    string trainName = split[0].Trim();
                    string otherTrainName = split[2].Trim();

                    string cmd = split[1].Trim();

                    if (cmd == "->")
                    {
                        if (!trains.ContainsKey(trainName))
                        {
                            trains.Add(trainName, new Train());
                            trains[trainName].Name = trainName;

                            trains[trainName].SumWagonPower = trains[otherTrainName].SumWagonPower;

                            trains[trainName].WagonsNameAndPower = new Dictionary<string, int>();

                            foreach (var wagon in trains[otherTrainName].WagonsNameAndPower)
                            {
                                trains[trainName].WagonsNameAndPower.Add(wagon.Key, 0);
                                trains[trainName].WagonsNameAndPower[wagon.Key] += wagon.Value;
                            }
                            trains.Remove(otherTrainName);
                        }

                        else
                        {
                            foreach (var wagon in trains[otherTrainName].WagonsNameAndPower)
                            {
                                trains[trainName].WagonsNameAndPower.Add(wagon.Key, 0);
                                trains[trainName].WagonsNameAndPower[wagon.Key] += wagon.Value;
                            }

                            trains[trainName].SumWagonPower += trains[otherTrainName].SumWagonPower;

                            trains.Remove(otherTrainName);
                        }
                    }
                    else if (cmd == "=")
                    {

                        if (!trains.ContainsKey(trainName))
                        {
                            trains.Add(trainName, new Train());
                            trains[trainName].Name = trainName;

                            trains[trainName].SumWagonPower = trains[otherTrainName].SumWagonPower;

                            trains[trainName].WagonsNameAndPower = new Dictionary<string, int>();

                            foreach (var wagon in trains[otherTrainName].WagonsNameAndPower)
                            {
                                trains[trainName].WagonsNameAndPower.Add(wagon.Key, 0);
                                trains[trainName].WagonsNameAndPower[wagon.Key] += wagon.Value;
                            }
                        }
                        else
                        {
                            trains[trainName].WagonsNameAndPower = trains[otherTrainName].WagonsNameAndPower;
                            trains[trainName].SumWagonPower = trains[otherTrainName].SumWagonPower;
                        }
                    }

                }
            }

            foreach (var train in trains.OrderByDescending(x=>x.Value.SumWagonPower))
            {
                Console.WriteLine($"Train: {train.Key}");
                foreach (var wagon in train.Value.WagonsNameAndPower.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }
    }
}
