using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end") { break; }
                var splitTheCommand = command.Split(' ');

                var cmd = splitTheCommand[0];

                if (cmd == "reverse")
                {
                    int from = int.Parse(splitTheCommand[2]);
                    int count = int.Parse(splitTheCommand[4]);
                    if (from < 0 || from > array.Length || (from + count) > array.Length || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        array = Reversing(array, from, count);

                    }
                }
                else if (cmd == "sort")
                {
                    int from = int.Parse(splitTheCommand[2]);
                    int count = int.Parse(splitTheCommand[4]);
                    if (from < 0 || (from + count) > array.Length || from >= array.Length || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        array = Sorting(array, from, count);

                    }

                }
                else if (cmd == "rollLeft")
                {
                    int count = int.Parse(splitTheCommand[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        array = RollLeft(array, count);

                    }
                }
                else if (cmd == "rollRight")
                {
                    int count = int.Parse(splitTheCommand[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        array = RollRight(array, count);

                    }
                }
            }
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }

        static string[] Reversing(string[] array, int from, int count)
        {
            List<string> theArray = array.ToList();
            int fromPosition = from;
            int amount = count;
            List<string> current = theArray.Skip(from).Take(amount).Reverse().ToList();
            theArray.RemoveRange(fromPosition, amount);
            theArray.InsertRange(fromPosition, current);
            
          
            return theArray.ToArray();
        }

        static string[] Sorting(string[] array, int from, int count)
        {
            List<string> theArray = array.ToList();
            List<string> theArrForOperation = theArray;

            int fromPosition = from;
            int amount = count;

            theArrForOperation = theArray.Skip(fromPosition).Take(amount).OrderBy(str => str).ToList();
            theArray.RemoveRange(fromPosition, count);
            theArray.InsertRange(fromPosition, theArrForOperation);

            return theArray.ToArray();
        }

        static string[] RollLeft(string[] array, int count)
        {
            List<string> theArray = array.ToList();
            int amount = count;

            for (int i = 0; i < amount % array.Length; i++)
            {
                string element = theArray[0];
                theArray.RemoveAt(0);
                theArray.Add(element);

            }

            return theArray.ToArray();
        }

        static string[] RollRight(string[] array, int count)
        {
            List<string> theArray = array.ToList();

            int amount = count;

            for (int i = 0; i < amount % array.Length; i++)
            {
                string element = theArray[theArray.Count - 1];
                theArray.RemoveAt(theArray.Count - 1);
                theArray.Insert(0, element);
            }           
            return theArray.ToArray();
        }
    }
}
