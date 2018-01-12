using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(' ').ToArray();
            string[] array2 = Console.ReadLine().Split(' ').ToArray();
            int count = 0;
            if (array1.Length >= array2.Length)
            {
                for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
                {
                    if (array1[i] == array2[i])
                    {
                        count++;
                    }

                }

            }
            else
            {
                for (int i = 0; i < Math.Min(array1.Length, array2.Length) + 1; i++)
                {
                    if (array1.Last() == array2.Last())
                    {
                        var newDeck = array1.Take(array1.Count() - 1).ToArray();
                        var newDeck2 = array2.Take(array2.Count() - 1).ToArray();
                        array1 = newDeck;
                        array2 = newDeck2;
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
