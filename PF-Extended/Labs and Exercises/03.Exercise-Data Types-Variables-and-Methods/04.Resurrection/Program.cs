using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());


            for (int i = 0; i < amount; i++)
            {
                long length = 0;
                decimal width = 0;
                int wingLength = 0;

                for (int j = 0; j < 3; j++)
                {
                    string input = Console.ReadLine();
                    switch (j)
                    {
                        case 0:
                            length = long.Parse(input);
                            break;
                        case 1:
                            width = decimal.Parse(input);
                            break;
                        case 2:
                            wingLength = int.Parse(input);
                            break;
                    }
                }
                decimal totalYears = (decimal)Math.Pow(length, 2) * (width + (2 * wingLength));
                Console.WriteLine(totalYears);
            }
        }
    }
}
