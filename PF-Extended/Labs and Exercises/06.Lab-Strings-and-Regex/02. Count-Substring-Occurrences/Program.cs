using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(' ').ToList();
            string containing = Console.ReadLine();

            int counter = 0;
            for (int i = 0; i < text.Count; i++)
            {
                if (text[i].ToLower().Contains(containing))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
