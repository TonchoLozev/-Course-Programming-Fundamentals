using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexaDecimal = Console.ReadLine();
            int decValue = Convert.ToInt32(hexaDecimal, 16);
            Console.WriteLine(decValue);
        }
    }
}
