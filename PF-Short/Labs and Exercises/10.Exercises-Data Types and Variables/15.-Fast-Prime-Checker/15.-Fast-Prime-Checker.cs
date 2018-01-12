using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isNumberPrime = true;
                for (int i2 = 2; i2 <= Math.Sqrt(i); i2++)
                {
                    if (i % i2 == 0)
                    {
                        isNumberPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isNumberPrime}");
            }

        }
    }
}
