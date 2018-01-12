using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] indexAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == indexAndPower[0])
                {
                    int left = Math.Max(i - indexAndPower[1], 0);
                    int right = Math.Min(i + indexAndPower[1], numbers.Count - 1);
                    int lenght = right - left + 1;
                    numbers.RemoveRange(left, lenght);
                    i = 0;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
