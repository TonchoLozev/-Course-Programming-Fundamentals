using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14._Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
            for (int i = 1; i <= number; i++)
            {
                factoriel = factoriel * i;
            }
            Console.WriteLine($"{CountingTheZeros(factoriel)}");
        }

        static int CountingTheZeros(BigInteger factorial)
        {
            int zeros = 0;
            while(true)
            {
                BigInteger lastNumber = factorial % 10 ;
                factorial /= 10;
                if (lastNumber == 0)
                {
                    zeros++;
                }
                else
                {
                    return zeros;
                }

            }
        }
    }
}
