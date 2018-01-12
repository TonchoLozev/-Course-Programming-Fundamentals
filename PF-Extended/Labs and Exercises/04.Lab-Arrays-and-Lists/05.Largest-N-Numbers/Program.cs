using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Largest_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            list.Sort();
            int n = int.Parse(Console.ReadLine());

            int last = list.Count-1;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{list[last]} ");
                last--;
            }
        }
    }
}
