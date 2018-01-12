using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotateTimes = int.Parse(Console.ReadLine());
            int[] sum = new int[integers.Length];
            for (int i = 0; i < rotateTimes; i++)
            {
                Rotation(integers);
                for (int j = 0; j < integers.Length; j++)
                {
                    sum[j] = sum[j] + integers[j];
                }              
            }
            Console.WriteLine(string.Join(" ", sum));
        }
        public static void Rotation(int [] array)
        {
            int lastElement = array[array.Length - 1];
            for (int i = array.Length-1; i > 0; i--)
            {
                array[i] = array[i - 1];               
            }
            array[0] = lastElement;            
        }
    }
}
