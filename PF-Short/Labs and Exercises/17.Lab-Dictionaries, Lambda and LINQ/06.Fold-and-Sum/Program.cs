using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> row1 = new List<int>();
            List<int> row2 = new List<int>();
            List<int> left = array.Take(array.Length / 4).Reverse().ToList();
            List<int> right = array.Reverse().Take(array.Length / 4).ToList();
            row1.AddRange(left);
            row1.AddRange(right);
            row2.AddRange(array);
            row2.RemoveRange(0, array.Length / 4);
            row2.Reverse();
            row2.RemoveRange(0, array.Length / 4);
            row2.Reverse();
            int[] sum = new int[array.Length/2];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = row1[i] + row2[i];
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
