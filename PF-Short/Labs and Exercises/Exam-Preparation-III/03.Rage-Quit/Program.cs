using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var pattern = @"([^0-9]+)(\d+)";
            StringBuilder sb = new StringBuilder();
            foreach (Match match in Regex.Matches(input,pattern))
            {
                    for (int i = 0; i < int.Parse(match.Groups[2].ToString()); i++)
                    {
                        string word = match.Groups[1].ToString().ToUpper();
                        sb.Append(word);
                    }
              
            }
            string result = sb.ToString();
            int uniqueSymbols = result.Distinct().Count();
            Console.WriteLine("Unique symbols used: "+uniqueSymbols);
            Console.WriteLine(result);
        }
    }
}
