using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().
                Split(new char[] { ',', ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).
                ToArray();
            Console.WriteLine(string.Join(", ", CheckWords(words).OrderBy(x => x)));
        }
        static List<string> CheckWords(string[] words)
        {
            List<string> isPalindrone = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                string original = words[i];
                string reversed = new string(words[i].Reverse().ToArray());
                if (original == reversed)
                {
                    isPalindrone.Add(original);
                }
            }
            return isPalindrone;
        }
    }
}
