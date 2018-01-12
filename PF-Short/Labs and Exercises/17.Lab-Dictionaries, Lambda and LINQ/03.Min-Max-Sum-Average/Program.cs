using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Min_Max_Sum_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> array = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                array.Add(numbers);
            }
            Console.WriteLine("Sum = " + array.Sum());
            Console.WriteLine("Min = " + array.Min());
            Console.WriteLine("Max = " + array.Max());
            Console.WriteLine("Average = " + array.Average());
        }
    }
}
