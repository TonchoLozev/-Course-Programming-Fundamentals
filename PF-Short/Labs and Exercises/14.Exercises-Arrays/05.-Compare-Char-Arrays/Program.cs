using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int upper = 0;

            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
                {
                    if (array1[i] < array2[i])
                    {
                        upper = 0;
                        break;
                    }
                    else
                    {
                        upper = 1;
                        break;
                    }
                }
                if (upper == 0)
                {
                    Console.WriteLine(string.Join("", array1));
                    Console.WriteLine(string.Join("", array2));
                }
                else
                {
                    Console.WriteLine(string.Join("", array2));
                    Console.WriteLine(string.Join("", array1));
                }
            }
            else if (array1.Length < array2.Length)
            {
                Console.WriteLine(string.Join("",array1));
                Console.WriteLine(string.Join("", array2));
            }
            else if (array1.Length > array2.Length)
            {
                Console.WriteLine(string.Join("", array2));
                Console.WriteLine(string.Join("", array1));
            }

        }
    }
}
