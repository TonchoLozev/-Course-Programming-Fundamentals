using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();

            BigInteger basee = BigInteger.Parse(numbers[0]);
            BigInteger number = BigInteger.Parse(numbers[1]);

            List<BigInteger> finalResult = new List<BigInteger>();

            int counter = 0;

            while (number > 0)
            {
                BigInteger lastDigit = number % 10;
                number /= 10;
                finalResult.Add(lastDigit * (BigInteger.Pow(basee, counter)));
                counter++;
            }

            BigInteger sum = 0;

            foreach (var item in finalResult)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}
