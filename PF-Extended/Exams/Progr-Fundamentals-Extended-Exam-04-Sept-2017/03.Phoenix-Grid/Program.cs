using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "ReadMe") { break; }

                if (input.Contains(" ") || input.Contains("_"))
                {
                    Console.WriteLine("NO");
                    continue;
                }

                string[] splited = input.Split('.');

                for (int i = 0; i < splited.Length; i++)
                {
                    if(splited[i].Length>3 || splited[i].Length < 3)
                    {
                        Console.WriteLine("NO");
                        break; 
                    }
                }

                if (input.SequenceEqual(input.Reverse()))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

            }

        }
    }
}
