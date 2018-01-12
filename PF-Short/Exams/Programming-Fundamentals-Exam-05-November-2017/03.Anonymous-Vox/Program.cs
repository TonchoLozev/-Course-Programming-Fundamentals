using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] valuesToPlace = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"([A-Za-z]{2,})(.+)\1";

            int count = 0;
            foreach (Match match in Regex.Matches(input, pattern))
            {
                string textToPlace = valuesToPlace[count];
                string textToReplacer = match.Groups[2].ToString();
                int index = match.Groups[2].Index;

                input = input.Replace(textToReplacer, textToPlace);
                count++;
            }
            Console.WriteLine(input);
        }
    }
}
