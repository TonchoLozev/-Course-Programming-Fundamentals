using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Testing_Skills
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>(Console.ReadLine().Split(' '));
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end") { break; }

                var splitTheCmd = command.Split(' ');
                var cmd = splitTheCmd[0];

                if (cmd == "reverse")
                {
                    int start = int.Parse(splitTheCmd[2]);
                    int count = int.Parse(splitTheCmd[4]);
                    if (start < 0 || start > input.Count || (count + start) > input.Count || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                    input = Reversing(input, start, count);
                }
                else if (cmd == "sort")
                {
                    int start = int.Parse(splitTheCmd[2]);
                    int count = int.Parse(splitTheCmd[4]);
                    if (start < 0 || start > input.Count || (count + start) > input.Count || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                    input = Sorting(input, start, count);
                }
                else if (cmd == "rollLeft")
                {
                    int count = int.Parse(splitTheCmd[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                    input = RollLeft(input, count);
                }
                else if (cmd == "rollRight")
                {
                    int count = int.Parse(splitTheCmd[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                    input = RollRight(input, count);
                }
            }
            Console.WriteLine("[" + string.Join(", ", input) + "]");
        }

        static List<string> Reversing(List<string> input, int start, int count)
        {
            List<string> list = new List<string>(input);
            list.Reverse(start, count);
            return list;
        }

        static List<string> Sorting(List<string> input, int start, int count)
        {
            List<string> list = new List<string>(input);
            list.Sort(start, count, null);
            return list;
        }

        static List<string> RollLeft(List<string> input, int count)
        {
            List<string> list = new List<string>(input);
            for (int i = 0; i < count % input.Count; i++)
            {
                var temp = list[0];
                list.RemoveAt(0);
                list.Add(temp);
            }
            return list;
        }

        static List<string> RollRight(List<string> input, int count)
        {
            List<string> list = new List<string>(input);
            list.Reverse();
            for (int i = 0; i < count % input.Count; i++)
            {
                var temp = list[0];
                list.RemoveAt(0);
                list.Add(temp);
            }
            list.Reverse();
            return list;
        }
    }
}
