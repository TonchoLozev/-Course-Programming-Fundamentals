using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> trains = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Traincode!") { break; }

                string pattern = @"(<\[[\W\D]*\].)(.\[[\w\d]*\].)*";

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    if(match.Length == input.Length)
                    {
                        trains.Add(input);
                    }
                }
            }

            foreach (var text in trains)
            {
                Console.WriteLine(text);
            }
        }
    }
}
