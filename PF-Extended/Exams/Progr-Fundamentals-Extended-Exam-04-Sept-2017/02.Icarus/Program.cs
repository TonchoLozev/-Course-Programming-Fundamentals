using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = int.Parse(Console.ReadLine());
            int position = start;
            int dmg = 1;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Supernova") { break; }

                string[] split = input.Split(' ');

                string side = split[0].Trim();
                int amount = int.Parse(split[1].Trim());

                if (side == "left")
                {
                    for (int i = 0; i < amount; i++)
                    {
                        position--;
                        if (position != -1)
                        {
                            array[position] -= dmg;
                        }
                        else
                        {
                            position = array.Length - 1;
                            dmg++;
                            array[position] -= dmg;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < amount; i++)
                    {
                        position++;
                        if (position != array.Length)
                        {
                            array[position] -= dmg;
                        }
                        else
                        {
                            position = 0;
                            dmg++;
                            array[position] -= dmg;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
