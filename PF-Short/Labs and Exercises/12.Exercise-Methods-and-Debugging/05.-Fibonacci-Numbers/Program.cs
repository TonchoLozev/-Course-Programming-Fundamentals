using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fibNum = Fib(n);
            Console.WriteLine((fibNum));
        }
        static int Fib(int number)
        {
            int fibNumber = 0;
            int fibLastNumber = 1;
            int sum = 0;
            for (int i = 0; i <= number; i++)
            {
                sum = fibNumber + fibLastNumber;
                fibNumber = fibLastNumber;
                fibLastNumber = sum; ;
            }
            return fibNumber;
        }
    }
}
