using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Маx_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int lenght = 1;
            int bestLenght = 0;
            int position = 0;
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if(numbers[i]==numbers[i+1])
                {
                    lenght++;
                    
                }
                else
                {
                    lenght = 1;
                }
                if(lenght>bestLenght)
                {
                    bestLenght = lenght;
                    position = numbers[i];
                }
            }
            for (int k = 0; k < bestLenght; k++)
            {
                Console.Write(position+" ");
            }
        }
    }
}
