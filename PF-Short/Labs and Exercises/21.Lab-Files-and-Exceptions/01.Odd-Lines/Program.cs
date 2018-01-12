using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            var oddLines = lines.Where((line, index) => index % 2 == 1);
            File.WriteAllLines("odd-file.txt", oddLines);
            string[] odd = File.ReadAllLines("odd-file.txt");
            Console.WriteLine(string.Join(Environment.NewLine, odd));
        }
    }
}
