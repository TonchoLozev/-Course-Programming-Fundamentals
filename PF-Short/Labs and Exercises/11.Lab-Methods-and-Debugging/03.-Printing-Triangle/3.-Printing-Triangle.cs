using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int firstHalf = 1; firstHalf <= n; firstHalf++)
            {
                PrintLine(1, firstHalf);
            }
            for (int secondHalf = n - 1; secondHalf >= 1; secondHalf--)
            {
                PrintLine(1, secondHalf);
            }
        }

        private static void PrintLine(int start, int end )
        {
            for (int i =  start; i <= end; i++)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine();
        }
    }
}
