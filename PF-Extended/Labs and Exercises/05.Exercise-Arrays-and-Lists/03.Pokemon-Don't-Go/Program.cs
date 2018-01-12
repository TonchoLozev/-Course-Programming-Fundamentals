using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            long sum = 0;
            while (array.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int removed = 0;

                if (index > array.Count - 1)
                {
                    removed = array[array.Count - 1];
                    array[array.Count - 1] = array[0];
                    sum += removed;
                }
                else if (index < 0)
                {
                    removed = array[0];
                    array[0] = array[array.Count - 1];
                    sum += removed;
                }
                else
                {
                    removed = array[index];
                    array.RemoveAt(index);
                    sum += removed;
                }


                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] <= removed)
                    {
                        array[i] += removed;
                    }
                    else
                    {
                        array[i] -= removed;
                    }
                }               
            }
            Console.WriteLine(sum);
        }
    }
}
