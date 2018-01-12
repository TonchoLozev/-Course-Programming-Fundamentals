using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] array = Console.ReadLine().ToCharArray().Select(c => c.ToString()).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if(array[i] == alphabet[j])
                    {
                        Console.WriteLine(string.Join(" ",array[i])+" -> " + (Array.IndexOf(alphabet,alphabet[j])));
                    }
                }
            }
        }
    }
}
