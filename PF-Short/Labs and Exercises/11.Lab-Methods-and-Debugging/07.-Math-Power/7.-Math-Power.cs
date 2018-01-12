using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = Calculation(number, power);
            Console.WriteLine(result);
        }
        static double Calculation(double number, int power)
        {
            double result = 1d;
            for (int i = 1; i <= power; i++)
            {
                result = result * number;
            }
            return result;
        }
    }
}
