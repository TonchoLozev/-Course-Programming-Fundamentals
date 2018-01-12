using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(?<=\s)([A-Za-z]|[0-9])+([._-])?([A-Za-z])*@([A-Za-z])+([.-])?[A-Za-z]+((\.)?([a-z]))*";
            var input = Console.ReadLine();
            
            foreach (Match match in Regex.Matches(input, pattern))
            {
                string email = match.ToString();
                if(!(email.StartsWith(".")|| email.StartsWith("-") || email.StartsWith("_") ||
                    email.EndsWith(".") || email.EndsWith("-") || email.EndsWith("_")))
                {
                    Console.WriteLine(match);
                }
                
            }
        }
    }
}
