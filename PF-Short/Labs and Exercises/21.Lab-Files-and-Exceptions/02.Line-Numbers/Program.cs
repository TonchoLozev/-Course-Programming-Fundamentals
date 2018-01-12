using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            string[] numberedLines = new string[input.Length];
            int number = 1;
            int counter = 0;
            foreach (var item in input)
            {
                numberedLines[counter] = $"{number} {input[counter]}";
                number++;
                counter++;
            }
            File.WriteAllLines("numbered-input.txt", numberedLines);
        }
    }
}
