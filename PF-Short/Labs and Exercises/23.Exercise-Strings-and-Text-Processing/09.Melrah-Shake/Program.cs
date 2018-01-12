using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();
            while (text.Length > 0 && pattern.Length > 0)
            {
                int firstIndex = text.IndexOf(pattern);
                int lastIndex = text.LastIndexOf(pattern);
                if (firstIndex >= 0 && lastIndex >= 0 && firstIndex != lastIndex)
                {
                    Console.WriteLine("Shaked it.");
                    text = text.Remove(firstIndex, pattern.Length);
                    lastIndex = text.LastIndexOf(pattern);
                    text = text.Remove(lastIndex, pattern.Length);
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}
