using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (Char.IsDigit(symbol))
            {
                Console.WriteLine("digit");
            }
            else if (symbol == 'a' || symbol == 'A' || symbol == 'e' || symbol == 'E' || symbol == 'i'
                || symbol == 'I' || symbol == 'o' || symbol == 'O' || symbol == 'u' || symbol == 'U')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
