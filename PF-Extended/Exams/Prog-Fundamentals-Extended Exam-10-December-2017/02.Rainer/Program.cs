using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> copy = new List<int>(arr.ToList());
            copy.RemoveAt(copy.Count - 1);

            int donalPosition = arr.Length - 1;

            int countSteps = 0;

            while (true)
            {
                for (int i = 0; i < copy.Count; i++)
                {
                    copy[i] -= 1;
                }

                if(donalPosition < copy.Count)
                {
                    if(copy[donalPosition] == 0)
                    {
                        break;
                    }
                }

                if (copy.Contains(0))
                {
                    for (int i = 0; i < copy.Count; i++)
                    {
                        if(copy[i] == 0)
                        {
                            copy[i] = arr[i];
                        }
                    }
                }

                int index = int.Parse(Console.ReadLine());

                countSteps++;

                donalPosition = index;
               
            }

            Console.WriteLine(string.Join(" ", copy));
            Console.WriteLine(countSteps);

        }
    }
}
