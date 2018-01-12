using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{num} + {num2} = {num + num2}");
        }
    }
}
