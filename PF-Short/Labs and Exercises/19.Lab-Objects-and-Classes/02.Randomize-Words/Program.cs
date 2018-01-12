using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            Random randomWords = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                var swapFirst = randomWords.Next(0, input.Length);
                var swapSecond = randomWords.Next(0,input.Length);
                var oldFirst = input[swapFirst];
                input[swapFirst] = input[swapSecond];
                input[swapSecond] = oldFirst;
            }
            Console.WriteLine(string.Join(Environment.NewLine,input));
        }
    }
}
