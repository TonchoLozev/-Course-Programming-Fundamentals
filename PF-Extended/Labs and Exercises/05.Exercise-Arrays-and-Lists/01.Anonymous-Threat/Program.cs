using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<string> result = new List<string>(input);

            while (true)
            {
                string inputLines = Console.ReadLine();
                if (inputLines == "3:1") { break; }

                string[] splited = inputLines.Split(' ');
                string cmd = splited[0];

                if (cmd == "merge")
                {
                    int start = int.Parse(splited[1]);
                    int end = int.Parse(splited[2]);

                    if (start < 0 || start >= result.Count) { start = 0; }
                    if (end < 0 || end >= result.Count) { end = result.Count - 1; }

                    string merged = "";

                    for (int i = start; i <= end; i++)
                    {
                        merged += result[i];
                    }

                    if (start == 0) { result.RemoveRange(start, (end - start) + 1); }
                    else { result.RemoveRange(start, (end - start) + 1); }

                    result.Insert(start, merged);
                }

                else if (cmd == "divide")
                {
                    int index = int.Parse(splited[1]);
                    int partitions = int.Parse(splited[2]);
                    string str = result[index];

                    int temp = str.Length / partitions;
                    List<string> tempList = new List<string>();

                    if (temp % 2 == 0)
                    {
                        for (int i = 0; i < partitions; i++)
                        {
                            string tempStr = str.Substring(0, temp);
                            str = str.Remove(0, temp);
                            tempList.Add(tempStr);
                        }
                    }

                    else
                    {
                        for (int i = 0; i < partitions - 1; i++)
                        {
                            string tempStr = str.Substring(0, temp);
                            str = str.Remove(0, temp);
                            tempList.Add(tempStr);
                        }
                        tempList.Add(str);
                    }

                    result.InsertRange(index, tempList);
                    result.RemoveAt(index + tempList.Count);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
