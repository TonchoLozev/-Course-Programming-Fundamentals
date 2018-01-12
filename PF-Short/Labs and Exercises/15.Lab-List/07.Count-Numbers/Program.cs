using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            int count = 1;                       
            
            for (int i = 0; i <= numbers.Count-2; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }               
                else
                {                    
                    Console.WriteLine(numbers[i]+" -> "+count);
                    count = 1;
                }
                if (i == numbers.Count - 2)
                {
                    Console.WriteLine(numbers[i] + " -> " + count);
                }
            }

        }
    }
}
