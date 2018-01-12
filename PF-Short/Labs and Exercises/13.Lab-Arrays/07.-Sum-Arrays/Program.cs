using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int array1Length = array1.Length;
            int array2Length = array2.Length;
            int max = Math.Max(array1Length, array2Length);

            for (int i = 0; i < max; i++)
            {
                int sum = array1[i % array1Length] + array2[i % array2Length];
                Console.Write(sum + " ");
            }

        }
    }
}
