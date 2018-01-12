using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] field = new int[size];
            int[] bugIndex = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < bugIndex.Length; i++)
            {
                int index = bugIndex[i];
                if (index > field.Length || index < 0)
                {
                    continue;
                }
                else
                {
                    field[index] = 1;
                }
            }
            List<int> list = new List<int>(field);
            //Console.WriteLine(string.Join(" ",field));    to see if field is corectly filled
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") { break; }

                string[] split = input.Split(' ');
                int fromPosition = int.Parse(split[0]);     //from which position
                string side = split[1];                  //to which side 
                int length = int.Parse(split[2]);           //how much times (length) to moove

                if (side == "right")
                {
                    if (list[fromPosition + length] == 0)
                    {
                        list[fromPosition + length] = 0;
                    }
                    else
                    {
                        for (int i = fromPosition+length; i < list.Count; i++)
                        {
                            ' '
                        }
                    }
                }
            }
        }
    }
}
