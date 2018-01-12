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
        public Dictionary<string, int> WagonNameAndPower { get; set; }
        public int TotalWagonPower { get; set; }
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

                string[] split = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (split.Length == 5)
                {
                    string trainName = split[0].Trim();
                    string wagonName = split[2].Trim();
                    int wagonPower = int.Parse(split[4].Trim());

                    if (!trains.ContainsKey(trainName))
                    {
                        //Add train to the dictionary with its options

                        trains.Add(trainName, new Train());

                        trains[trainName].WagonNameAndPower = new Dictionary<string, int>();

                        trains[trainName].Name = trainName;
                        trains[trainName].WagonNameAndPower.Add(wagonName, 0);
                        trains[trainName].WagonNameAndPower[wagonName] += wagonPower;
                        trains[trainName].TotalWagonPower += wagonPower;
                    }
                    else
                    { 

                        trains[trainName].WagonNameAndPower.Add(wagonName, 0);
                        trains[trainName].WagonNameAndPower[wagonName] += wagonPower;
                        trains[trainName].TotalWagonPower += wagonPower;
                    }
                }
                else if (split.Length == 3)
                {
                    string trainName = split[0].Trim();
                    string otherTrainName = split[2].Trim();

                    if (split[1] == "=")
                    {
                        if (!trains.ContainsKey(trainName))
                        {
                            trains.Add(trainName, new Train());

                            trains[trainName].WagonNameAndPower = new Dictionary<string, int>();

                            foreach (var wagon in trains[otherTrainName].WagonNameAndPower)
                            {
                                trains[trainName].WagonNameAndPower.Add(wagon.Key, 0);
                                trains[trainName].WagonNameAndPower[wagon.Key] += wagon.Value;
                                trains[trainName].TotalWagonPower = trains[otherTrainName].TotalWagonPower;
                            }
                        }
                        else
                        {
                            trains.Remove(trainName);

                            trains.Add(trainName, new Train());

                            trains[trainName].WagonNameAndPower = new Dictionary<string, int>();

                            foreach (var wagon in trains[otherTrainName].WagonNameAndPower)
                            {
                                trains[trainName].WagonNameAndPower.Add(wagon.Key, 0);
                                trains[trainName].WagonNameAndPower[wagon.Key] += wagon.Value;
                                trains[trainName].TotalWagonPower = trains[otherTrainName].TotalWagonPower;
                            }
                        }
                    }
                    else
                    {
                        if (!trains.ContainsKey(trainName))
                        {
                            trains.Add(trainName, new Train());

                            trains[trainName].WagonNameAndPower = new Dictionary<string, int>();

                            foreach (var wagon in trains[otherTrainName].WagonNameAndPower)
                            {
                                trains[trainName].WagonNameAndPower.Add(wagon.Key, 0);
                                trains[trainName].WagonNameAndPower[wagon.Key] += wagon.Value;
                                trains[trainName].TotalWagonPower = trains[otherTrainName].TotalWagonPower;
                            }
                        }
                        else
                        {
                            foreach (var wagon in trains[otherTrainName].WagonNameAndPower)
                            {
                                trains[trainName].WagonNameAndPower.Add(wagon.Key, 0);
                                trains[trainName].WagonNameAndPower[wagon.Key] += wagon.Value;
                                trains[trainName].TotalWagonPower += trains[otherTrainName].TotalWagonPower;
                            }
                        }

                        trains.Remove(otherTrainName);
                    }
                }
            }
         

            foreach (var train in trains.OrderByDescending(x=>x.Value.TotalWagonPower))
            {
                Console.WriteLine($"Train: {train.Key}");
                foreach (var wagoon in train.Value.WagonNameAndPower.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"###{wagoon.Key} - {wagoon.Value}");
                }
            }
        }
    }
}
