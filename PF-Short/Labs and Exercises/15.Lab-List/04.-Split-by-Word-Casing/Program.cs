using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().
                Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> lowerCases = new List<string>();
            List<string> upperCases = new List<string>();
            List<string> mixedCases = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                int countingLowerCases = 0;
                int countingUpperCases = 0;

                char[] splitingToChar = words[i].ToCharArray();
                for (int j = 0; j < splitingToChar.Length; j++)
                {
                    if (char.IsUpper(splitingToChar[j]))
                    {
                        countingUpperCases++;
                    }
                    else if (char.IsLower(splitingToChar[j]))
                    {
                        countingLowerCases++;
                    }
                }
                if (countingUpperCases == words[i].Length)
                {
                    upperCases.Add(words[i]);
                }
                else if (countingLowerCases == words[i].Length)
                {
                    lowerCases.Add(words[i]);
                }
                else
                {
                    mixedCases.Add(words[i]);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCases));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCases));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCases));
        }
    }
}
