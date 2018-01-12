using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"<a\s+href=(.+?)>(.+?)<\/a>";
            Regex regex = new Regex(pattern);
            var text = Console.ReadLine();

            StringBuilder lines = new StringBuilder();

            while(true)
            {
                lines = lines.AppendLine(text);
                text = Console.ReadLine();
                if (text == "end") { break; }
            }

            text = lines.ToString();

            var replacement = "[URL href=$1]$2[/URL]";          
            string result = regex.Replace(text, replacement);
            Console.WriteLine(result);
        }
    }
}
