using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = ConvertingFtoC(fahrenheit);
            Console.WriteLine($"{celsius:F2}");
        }
        static double ConvertingFtoC(double degrees)
        {
            return (degrees - 32) * 5 / 9; 
        }
    }
}
