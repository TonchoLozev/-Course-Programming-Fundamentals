using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (numbers.Length == 3 || numbers.Length == 2)
            {
                Console.WriteLine("no");
            }
            else if (numbers.Length == 1)
            {
                Console.WriteLine(0);
            }
            Sum(numbers);
        }
        static void Sum(int[] array)
        {
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 1; i < array.Length; i++)
            {
                for (int left = i - 1; left < i; left++)
                {
                    leftSum += array[left];
                }
                for (int right = i + 1; right < array.Length; right++)
                {
                    rightSum += array[right];

                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    break;
                }
                rightSum = 0;

            }
        }
    }
}
