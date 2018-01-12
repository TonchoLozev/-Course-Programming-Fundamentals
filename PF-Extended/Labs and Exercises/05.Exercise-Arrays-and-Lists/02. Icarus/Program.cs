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
            int[] plane = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = int.Parse(Console.ReadLine());
            int postion = start;
            int dmg = 1;
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Supernova") { break; }

                string[] splited = input.Split(' ');
                string cmd = splited[0];
               

                if (cmd == "left")
                {
                    int steps = int.Parse(splited[1]);                   
                    for (int i = 0; i < steps; i++)
                    {
                        postion--;
                        if (postion != -1)
                        {
                            plane[postion] -= dmg;
                        }
                        else
                        {
                            postion = plane.Length - 1;
                            dmg++;
                            plane[postion] -= dmg;
                        }
                    }
                }
                if(cmd == "right")
                {
                    int steps = int.Parse(splited[1]);
                    for (int i = 0; i < steps; i++)
                    {
                        postion++;
                        if(postion != plane.Length)
                        {
                            plane[postion] -= dmg;
                        }
                        else
                        {
                            postion = 0;
                            dmg++;
                            plane[postion] -= dmg;
                        }
                    }
                }              
            }
            Console.WriteLine(string.Join(" ", plane));
        }
    }
}
