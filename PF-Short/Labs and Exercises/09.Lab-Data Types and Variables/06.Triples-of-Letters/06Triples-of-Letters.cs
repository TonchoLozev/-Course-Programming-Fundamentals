using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // char letter = (char)('a' + num-1); << how to convert numbers to letter 
            for (int i1 = 1; i1 <= n; i1++)
            {
                for (int i2 = 1; i2 <= n; i2++)
                {
                    for (int i3 = 1; i3 <= n; i3++)
                    {
                        char letter1 = (char)('a' + i1 - 1);
                        char letter2 = (char)('a' + i2 - 1);
                        char letter3 = (char)('a' + i3 - 1);

                        Console.WriteLine($"{letter1}{letter2}{letter3}");
                    }
                }
            }
        }
    }
}
