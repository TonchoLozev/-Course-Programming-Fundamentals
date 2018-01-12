using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(' ');
            var counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                counts[word] = 0;
            }
            foreach (var word in words)
            {
                counts[word]++;
            }
            List<string> result = new List<string>();
            foreach (var item in counts)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
