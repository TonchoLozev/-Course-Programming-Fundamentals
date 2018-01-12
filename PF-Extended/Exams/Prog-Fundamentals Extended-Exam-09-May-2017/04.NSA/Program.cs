using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NSA
{
    class Spy
    {
        public string CountryName { get; set; }
        public Dictionary<string, int> SpyNameAndDaysInService { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Spy> countries = new Dictionary<string, Spy>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "quit") { break; }

                string[] split = input.Split(' ');

                string countryName = split[0].Trim();
                string spyName = split[2].Trim();
                int daysInService = int.Parse(split[4].Trim());

                if (!countries.ContainsKey(countryName))
                {
                    countries.Add(countryName, new Spy());
                    countries[countryName].SpyNameAndDaysInService = new Dictionary<string, int>();
                    countries[countryName].SpyNameAndDaysInService.Add(spyName, 0);
                    countries[countryName].SpyNameAndDaysInService[spyName] += daysInService;
                }
                else
                {
                    if (!countries[countryName].SpyNameAndDaysInService.ContainsKey(spyName))
                    {
                        countries[countryName].SpyNameAndDaysInService.Add(spyName, 0);
                        countries[countryName].SpyNameAndDaysInService[spyName] += daysInService;
                    }
                    else
                    {
                        countries[countryName].SpyNameAndDaysInService[spyName] = daysInService;
                    }
                }
            }

            foreach (var country in countries.OrderByDescending(x=>x.Value.SpyNameAndDaysInService.Count))
            {
                Console.WriteLine($"Country: {country.Key}");
                foreach (var spy in country.Value.SpyNameAndDaysInService.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }
            }
        }
    }
}
