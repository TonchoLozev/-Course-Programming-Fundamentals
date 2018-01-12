using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isTrue = false;
            for (int i = 0; i < integers.Length; i++)
            {
                int checkDigitA = integers[i];              
                for (int j = i+1; j < integers.Length; j++)
                {
                    int checkDigitB = integers[j];
                    int sum = checkDigitA + checkDigitB;                   
                    if(integers.Contains(sum))
                    {
                        Console.WriteLine($"{integers[i]} + {integers[j]} == {sum}");
                        isTrue = true;
                    }
                }
            }
            if (isTrue == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
