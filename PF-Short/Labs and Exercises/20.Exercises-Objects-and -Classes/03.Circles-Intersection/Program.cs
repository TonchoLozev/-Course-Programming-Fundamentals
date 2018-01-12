using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Circle
    {
        public Point Center = new Point();
        public int Radius { get; set; }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Circle circle = new Circle();
            circle.Center.X = int.Parse(input[0]);
            circle.Center.Y = int.Parse(input[1]);
            circle.Radius = int.Parse(input[2]);

            string[] secondInput = Console.ReadLine().Split();
            Circle secondCircle = new Circle();
            secondCircle.Center.X = int.Parse(secondInput[0]);
            secondCircle.Center.Y = int.Parse(secondInput[1]);
            secondCircle.Radius = int.Parse(secondInput[2]);

            double distance = CalculateDistance(circle.Center, secondCircle.Center);

            if (distance <= circle.Radius + secondCircle.Radius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
        static double CalculateDistance(Point a, Point b)
        {
            double sideA = a.X - b.X;
            double sideB = a.Y - b.Y;
            double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return distance;
        }
    }
}
