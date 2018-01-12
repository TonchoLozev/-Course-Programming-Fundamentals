using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Sieve_of_Eratosthenes1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool[] arrayOfNumbers = new bool[number + 1];
            
            for (int numberLenght = 2; numberLenght <= number; numberLenght++)
            {
                arrayOfNumbers[numberLenght] = true;
            }
            for (int p = 2; p * p <= number; p++)
            {
                if (arrayOfNumbers[p] == true)
                {
                    for (int i = p * 2; i <= number; i += p)
                    {
                        arrayOfNumbers[i] = false;
                    }
                }
            }
            for (int i = 2; i <= number; i++)
            {
                if (arrayOfNumbers[i])
                {
                    Console.Write(string.Join(" ", i)+" ");
                }
            }
        }
    }
}
