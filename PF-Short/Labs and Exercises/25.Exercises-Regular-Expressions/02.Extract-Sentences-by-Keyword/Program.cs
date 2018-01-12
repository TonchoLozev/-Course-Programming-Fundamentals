using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] text = Console.ReadLine().Split('.','?','!');
            var pattern = $@"(\b{word}\b)";
            foreach (string sentence in text)
            {
                Match match = Regex.Match(sentence, pattern);
                if(match.Success)
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
