using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(Reversed(text));
            
        }
        static string Reversed(string text)
        {
            StringBuilder reverse = new StringBuilder();
            for (int i = text.Length-1; i >=0 ; i--)
            {
                reverse.Append(text[i]);
            }
            return reverse.ToString();
        }
    }
}
