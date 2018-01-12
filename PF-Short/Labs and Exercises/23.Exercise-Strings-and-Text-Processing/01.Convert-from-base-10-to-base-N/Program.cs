using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            BigInteger numberToConvertTo = BigInteger.Parse(numbers[0]);
            BigInteger nummberToBeConverted = BigInteger.Parse(numbers[1]);    
            
            List<BigInteger> final = new List<BigInteger>();

            while (nummberToBeConverted > 0)
            {
                BigInteger reminder = nummberToBeConverted % numberToConvertTo;
                final.Add(reminder);
                nummberToBeConverted /= numberToConvertTo;
            }

            final.Reverse();
            Console.WriteLine(string.Join("",final));
        }
    }
}
