using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int fromChar = int.Parse(Console.ReadLine());
            int toChar = int.Parse(Console.ReadLine());
            // char b = Convert.ToChar(a); how to convert
            for (int from = fromChar; from <= toChar; from++)
            {
                char symbol = Convert.ToChar(from);
                Console.Write($" {symbol}");
            }
            
        }
    }
}
