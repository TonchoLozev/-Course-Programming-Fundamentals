using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            switch(figure)
            {
                case "triangle":
                    double sideTriangle = double.Parse(Console.ReadLine());
                    double hightTriangle = double.Parse(Console.ReadLine());
                    double areaTriangle = (sideTriangle * hightTriangle) / 2;
                    Console.WriteLine($"{areaTriangle:F2}");
                    break;
                case "square":
                    double sideSquare = double.Parse(Console.ReadLine());
                    double areaSquare = sideSquare * sideSquare;
                    Console.WriteLine($"{areaSquare:F2}");
                    break;
                case "rectangle":
                    double widthRectangle = double.Parse(Console.ReadLine());
                    double hightRectangle = double.Parse(Console.ReadLine());
                    double areaRectangle = widthRectangle * hightRectangle;
                    Console.WriteLine($"{areaRectangle:F2}");
                    break;
                case "circle":
                    double radiusCircle = double.Parse(Console.ReadLine());
                    double areaCircle = Math.PI * Math.Pow(radiusCircle, 2);
                    Console.WriteLine($"{areaCircle:F2}");
                    break;

            }
        }
    }
}
