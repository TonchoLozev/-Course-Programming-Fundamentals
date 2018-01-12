using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = GetMultipleOfTwoDigits((Math.Abs(number)));
            Console.WriteLine(sum);
        }
        static int GetMultipleOfTwoDigits(int n)
        {
            int sumOfEven = GetSumOfEven(n);
            int sumOfOdd = GetSumOfOdd(n);
            return sumOfEven * sumOfOdd;
        }

        static int GetSumOfOdd(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if(lastDigit % 2 != 0)
                {
                    sum = sum + lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetSumOfEven(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum = sum + lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
    }
}
