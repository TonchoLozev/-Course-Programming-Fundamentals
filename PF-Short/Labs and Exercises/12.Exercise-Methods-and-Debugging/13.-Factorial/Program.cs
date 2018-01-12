using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13._Factorial
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
            Console.WriteLine(factoriel);
        }
    }
}
