using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            string input = Console.ReadLine();
            //var numbers = Regex.Matches(input, pattern).Cast<Match>().Select(a => a.Value).ToArray();
            //Console.WriteLine(string.Join(" ",numbers));
            foreach  (Match match in Regex.Matches(input,pattern))
            {
                string m = match.Value.Trim();
                Console.Write(m+" ");
            }
        } 
    }
}
