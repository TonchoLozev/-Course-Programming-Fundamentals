using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder s = new StringBuilder();
            foreach (var item in text)
            {
               s.AppendFormat($"\\u{(int)item :x4}");
            }
            Console.WriteLine(s);
        }
    }
}
