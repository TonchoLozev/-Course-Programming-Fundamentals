using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] characters = Console.ReadLine().Split(' ');
            for (int i = characters.Length-1; i >=0; i--)
            {
                Console.Write($"{characters[i]} ");
            }
        }
    }
}
