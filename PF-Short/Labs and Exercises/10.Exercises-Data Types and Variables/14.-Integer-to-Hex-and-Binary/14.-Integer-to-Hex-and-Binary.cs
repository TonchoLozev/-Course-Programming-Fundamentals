using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            string integerToHex = integer.ToString("X");
            string integerToBinary = Convert.ToString(integer, 2);
            Console.WriteLine(integerToHex);
            Console.WriteLine(integerToBinary);

        }
    }
}
