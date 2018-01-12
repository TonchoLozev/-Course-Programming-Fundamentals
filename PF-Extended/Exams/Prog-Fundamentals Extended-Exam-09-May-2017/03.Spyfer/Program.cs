using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 1; i < arr.Count - 1; i++)
            {
                int sum = arr[i - 1] + arr[i + 1];
                if (arr[i] == sum)
                {
                    arr.RemoveAt(i-1);
                    arr.RemoveAt(i);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
