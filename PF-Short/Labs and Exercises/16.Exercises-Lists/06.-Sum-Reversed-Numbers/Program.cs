using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] reversedNumbers = new int[numbers.Length];
            int sum = 0;
            for (int i = 0; i < reversedNumbers.Length; i++)
            {
                reversedNumbers[i]= int.Parse(numbers[i].ToString().Reverse().Aggregate("", (s, c) => s + c));
                sum = sum + reversedNumbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
