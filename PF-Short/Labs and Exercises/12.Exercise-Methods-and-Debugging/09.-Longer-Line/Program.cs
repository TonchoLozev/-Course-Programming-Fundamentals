using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double distanceOfFirstPair = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double distanceOfSecondPair = GetingDistanceOfSecondPair(x3, y3, x4, y4);           
            if (distanceOfFirstPair>distanceOfSecondPair)
            {
                GettingTheClosestPoint(x1, y1, x2, y2);                
            }
            else
            {
                GettingTheClosestPoint(x3, y3, x4, y4);
            }
        }

        static void GettingTheClosestPoint(double x1, double y1, double x2, double y2)
        {
            double distance1 = Math.Abs(x1 + y1);
            double distance2 = Math.Abs(x2 + y2);
            if (distance1 < distance2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                
            }
            else if (distance1 == distance2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                
            }
        }

        static double GetingDistanceOfSecondPair(double x3, double y3, double x4, double y4)
        {
            double distance = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            return distance;
        }
    }
}
