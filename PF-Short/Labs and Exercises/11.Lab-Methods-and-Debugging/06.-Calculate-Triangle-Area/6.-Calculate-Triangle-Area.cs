using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double higth = double.Parse(Console.ReadLine());
            double calculating = CalculateTriangleArea(width, higth);
            Console.WriteLine(calculating);
        }

        private static double CalculateTriangleArea(double width, double higth)
        {
            return width * higth / 2;
        }
    }
}
