using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "3:1") { break; }

                string[] split = input.Split(' ');

                string command = split[0].Trim();

                if (command == "merge")
                {
                    int startIndex = int.Parse(split[1].Trim());
                    int endIndex = int.Parse(split[2].Trim());

                    if (startIndex < 0 || startIndex > list.Count - 1) { startIndex = 0; }
                    if (endIndex >= list.Count || endIndex < 0) { endIndex = list.Count - 1; }

                    StringBuilder merging = new StringBuilder();

                    int count = 0;
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        merging.Append(list[i]);
                        count++;
                    }
                    string merged = merging.ToString();

                    list.RemoveRange(startIndex, count);
                    list.Insert(startIndex, merged);
                }

                else if (command == "divide")
                {
                    int elementIndex = int.Parse(split[1].Trim());
                    int partitions = int.Parse(split[2].Trim());

                    List<string> dividing = new List<string>();

                    string str = list[elementIndex];
                    int stringLength = str.Length;
                    int chunkSize = stringLength / partitions;
                    if (stringLength % partitions == 0)
                    {
                        for (int i = 0; i < stringLength; i += chunkSize)
                        {
                            if (i + chunkSize > stringLength) chunkSize = stringLength - i;

                            dividing.Add(str.Substring(i, chunkSize));
                        }
                    }
                    else
                    {
                        for (int i = 0; i < stringLength - 1; i += chunkSize)
                        {
                            if (i + chunkSize > stringLength) chunkSize = stringLength - i;

                            if (i == stringLength - 2)
                            {
                                dividing.Add(str.Substring(i, stringLength-2));
                            }
                            else
                            {
                                dividing.Add(str.Substring(i, chunkSize));
                            }

                        }
                    }

                    list.RemoveAt(elementIndex);
                    list.InsertRange(elementIndex, dividing);
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
