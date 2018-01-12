using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            WhatKindOfParameterDoWeNeed(parameter, side);
        }
        static void WhatKindOfParameterDoWeNeed(string parameter, double side)
        {
            switch(parameter)
            {
                case "face":
                    Console.WriteLine($"{FaceOfTheCube(side):F2}");
                    break;
                case "space":
                    Console.WriteLine($"{SpaceOfTheCube(side):F2}");
                    break;
                case "volume":
                    Console.WriteLine($"{VolumeOfTheCube(side):F2}");
                    break;
                case "area":
                    Console.WriteLine($"{AreaOfTheCube(side):F2}");
                    break;
            }
        }
        
        static double FaceOfTheCube(double side)
        {
            double face = side * (Math.Sqrt(2));
            return face;
        }

        static double SpaceOfTheCube(double side)
        {
            double space = Math.Sqrt(3 * Math.Pow(side, 2));
            return space;
        }

        static double VolumeOfTheCube(double side)
        {
            double volume = Math.Pow(side, 3);
            return volume;
        }

        static double AreaOfTheCube(double side)
        {
            double area = 6 * Math.Pow(side, 2);
            return area;
        }
    }
}
