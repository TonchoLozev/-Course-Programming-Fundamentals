using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = 0;

            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double hight = double.Parse(Console.ReadLine());

            volume = (length * width * hight/ 3);
            Console.WriteLine($"Pyramid Volume: {volume:F2}");
        }
    }
}
