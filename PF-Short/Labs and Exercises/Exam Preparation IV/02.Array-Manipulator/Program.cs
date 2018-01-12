using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") { break; }

                string[] split = input.Split(' ');
                string cmd = split[0];

                if (cmd == "exchange")
                {
                    int index = int.Parse(split[1]);
                    if (index > array.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        array = Exchange(array, index);
                    }
                }
                else if (cmd == "max")
                {

                    if (split[1] == "even")
                    {
                        if (MaxEvenOrOdd(array, split[1]) == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(MaxEvenOrOdd(array, split[1]));
                        }
                    }
                    else if (split[1] == "odd")
                    {
                        if (MaxEvenOrOdd(array, split[1]) == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(MaxEvenOrOdd(array, split[1]));
                        }
                    }
                }
                else if (cmd == "min")
                {
                    if (split[1] == "even")
                    {
                        if (MinEvenOrOdd(array, split[1]) == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(MinEvenOrOdd(array, split[1]));
                        }
                    }
                    else if (split[1] == "odd")
                    {
                        if (MinEvenOrOdd(array, split[1]) == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(MinEvenOrOdd(array, split[1]));
                        }
                    }
                }
                else if (cmd == "first")
                {
                    int index = int.Parse(split[1]);
                    if (index <= array.Count)
                    {
                        if (split[2] == "even")
                        {
                            if (FirstElemets(array, index, split[2]).Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine("[" + string.Join(", ", FirstElemets(array, index, split[2])) + "]");
                            }

                        }
                        else
                        {
                            if (FirstElemets(array, index, split[2]).Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine("[" + string.Join(", ", FirstElemets(array, index, split[2])) + "]");
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }
                else if (cmd == "last")
                {
                    int index = int.Parse(split[1]);
                    if (index <= array.Count)
                    {

                        if (split[2] == "even")
                        {
                            if (LastElemets(array, index, split[2]).Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine("[" + string.Join(", ", LastElemets(array, index, split[2])) + "]");
                            }
                        }
                        else
                        {
                            if (LastElemets(array, index, split[2]).Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine("[" + string.Join(", ", LastElemets(array, index, split[2])) + "]");
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }
            }
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }

        static List<int> Exchange(List<int> array, int index)
        {
            List<int> arr = array;
            int from = index + 1;

            List<int> first = new List<int>(arr.Take(from));
            List<int> second = new List<int>(arr.Skip(from));
            List<int> result = new List<int>();

            result.AddRange(second);
            result.AddRange(first);

            return result;
        }

        static int MaxEvenOrOdd(List<int> array, string oddOrEven)
        {
            int count = 0;
            int even = int.MinValue;
            int odd = int.MinValue;
            if (oddOrEven == "even")
            {
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (array[i] >= even)
                        {
                            even = array[i];
                            count = i;
                        }
                    }
                }
                if (even == int.MinValue)
                {
                    return -1;
                }
                else
                {
                    return count;
                }                  
            }
            else
            {
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        if (array[i] >= odd)
                        {
                            odd = array[i];
                            count = i;
                        }
                    }
                }
                if (odd == int.MinValue)
                {
                    return -1;
                }
                else
                {
                    return count;
                }
            }
        }
        static int MinEvenOrOdd(List<int> array, string oddOrEven)
        {
            int count = 0;
            int even = int.MaxValue;
            int odd = int.MaxValue;
            if (oddOrEven == "even")
            {
                for (int i = array.Count - 1; i >= 0; i--)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (array[i] < even)
                        {
                            even = array[i];
                            count = i;
                        }
                    }
                }
                if (even == int.MaxValue)
                {
                    return -1;
                }
                else
                {
                    return count;
                }
            }
            else
            {
                for (int i = array.Count - 1; i >= 0; i--)
                {
                    if (array[i] % 2 != 0)
                    {
                        if (array[i] < odd)
                        {
                            odd = array[i];
                            count = i;
                        }
                    }
                }
                if (odd == int.MaxValue)
                {
                    return -1;
                }
                else
                {
                    return count;
                }
            }
        }
        static List<int> FirstElemets(List<int> array, int count, string evenOrOdd)
        {
            List<int> reutrn = new List<int>();
            if (evenOrOdd == "even")
            {
                for (int i = 0; i < array.Count; i++)
                {
                    if (reutrn.Count > count - 1)
                    {
                        break;
                    }
                    if (array[i] % 2 == 0)
                    {
                        reutrn.Add(array[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Count; i++)
                {
                    if (reutrn.Count > count - 1)
                    {
                        break;
                    }
                    if (array[i] % 2 != 0)
                    {
                        reutrn.Add(array[i]);
                    }
                }
            }
            return reutrn;
        }
        static List<int> LastElemets(List<int> array, int count, string evenOrOdd)
        {
            List<int> reutrn = new List<int>();
            if (evenOrOdd == "even")
            {
                for (int i = array.Count - 1; i >= 0; i--)
                {
                    if (reutrn.Count > count - 1)
                    {
                        break;
                    }
                    if (array[i] % 2 == 0)
                    {
                        reutrn.Add(array[i]);
                    }
                }
            }
            else
            {
                for (int i = array.Count - 1; i >= 0; i--)
                {
                    if (reutrn.Count > count - 1)
                    {
                        break;
                    }
                    if (array[i] % 2 != 0)
                    {
                        reutrn.Add(array[i]);
                    }
                }
            }
            return reutrn;
        }
    }
}
