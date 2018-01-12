using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dict = new Dictionary<string, Dictionary<string, long>>();
            string info = Console.ReadLine();
            while(info != "report")
            {
                var split = info.Split('|').ToList();
                string city = split[0];
                string country = split[1];
                long population = long.Parse(split[2]);
                if(!dict.ContainsKey(country))
                {
                    dict.Add(country, new Dictionary<string, long>());
                    dict[country].Add(city, population);
                }
                if (!dict[country].ContainsKey(city))
                {
                    dict[country].Add(city, population);
                }               
                info = Console.ReadLine();
            }
            foreach (var countryy in dict.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                List<long> sumOfTowns = countryy.Value.Select(x => x.Value).ToList();

                Console.WriteLine("{0} (total population: {1})", countryy.Key, sumOfTowns.Sum());

                foreach (var cityy in countryy.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("=>{0}: {1}", cityy.Key, cityy.Value);
                }
            }

        }
    }
}
