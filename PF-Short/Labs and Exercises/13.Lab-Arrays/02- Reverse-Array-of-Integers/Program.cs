using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02__Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var nums = new int[number];

            for (int i = 0; i < number; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            for (int i = nums.Length-1; i >= 0; i--)
            {
                Console.Write(nums[i]+" ");
            }
        }
    }
}
