using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BottomAndTop(n);
            for (int i = 1; i <= n - 2; i++)
            {
                Middle(n);
            }
            BottomAndTop(n);
        }

        static void BottomAndTop(int times)
        {
            Console.Write(new string('-', 2 * times));
            Console.WriteLine();
        }
        static void Middle(int cycleTimes)
        {
            Console.Write("-");
            for (int i = 1; i <= cycleTimes-1; i++)
            {
                Console.Write("\\/");  
            }
            Console.WriteLine("-");
        }
    }
}
