using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().
                ToLower().
                Split(new char[] { ' ', ',', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var shortChar = words.Where(x => x.Length < 5).OrderBy(x => x).Distinct();
            Console.WriteLine(string.Join(", ",shortChar));
        }
    }
}
