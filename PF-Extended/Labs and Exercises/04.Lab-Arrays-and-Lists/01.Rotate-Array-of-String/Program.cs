using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Rotate_Array_of_String
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string lastElement = arr[arr.Count - 1];
            arr.Insert(0, lastElement);
            arr.RemoveAt(arr.Count - 1);

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
