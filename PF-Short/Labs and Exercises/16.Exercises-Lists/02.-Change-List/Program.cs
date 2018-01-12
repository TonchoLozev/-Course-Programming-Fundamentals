using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool isTrue = true;
            while (isTrue == true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "Delete")
                {
                    int removingElement = int.Parse(command[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers.Remove(removingElement);
                    }
                }
                else if (command[0] == "Insert")
                {
                    int insertingElement = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    numbers.Insert(position,insertingElement);
                }
                if (command[0] == "Odd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write(string.Join(" ", numbers[i]) + " ");
                        }
                    }
                    break;
                }
                else if (command[0] == "Even")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write(string.Join(" ", numbers[i]) + " ");
                        }
                    }
                    break;
                }
            }
        }
    }
}
