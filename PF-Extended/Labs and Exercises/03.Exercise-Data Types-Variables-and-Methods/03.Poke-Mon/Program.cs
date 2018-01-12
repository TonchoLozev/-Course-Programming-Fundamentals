using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            ushort exhoustion = ushort.Parse(Console.ReadLine());
            int half = (power * 50) / 100;
            int count = 0;
            while (true)
            {
                if (power < distance || power - distance < 0) { break; }
                count++;
                if (power == half)
                {
                    if (power / exhoustion != 0)
                    {
                        power /= exhoustion;
                        power -= distance;
                        continue;
                    }
                }
                power -= distance;
            }
            Console.WriteLine(power);
            Console.WriteLine(count);
        }
    }
}
