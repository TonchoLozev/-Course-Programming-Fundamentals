using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> result = new List<double>();
            for (int i = numbers.Count-1; i >= 0; i--)
            {
                if(numbers[i]>0)
                {
                    result.Add(numbers[i]);
                }              
            }
            if(result.Count>0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
