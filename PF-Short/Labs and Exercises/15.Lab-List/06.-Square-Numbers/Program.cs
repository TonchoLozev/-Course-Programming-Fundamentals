using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> isSquare = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt((int)numbers[i]) % 1 == 0)
                {
                    isSquare.Add(numbers[i]);
                }
            }
            isSquare.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", isSquare));
        }
    }
}
