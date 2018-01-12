using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
        }   
    }
}
