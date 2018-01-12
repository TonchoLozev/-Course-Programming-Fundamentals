using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Numbers_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if(i % 2 != 0)
                {
                    int number = list[i];
                    if(number % 2 != 0)
                    {
                        Console.WriteLine($"Index {i} -> {number}");
                    }
                }
            }
        }
    }
}
