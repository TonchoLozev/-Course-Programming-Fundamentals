using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            while (true)
            {
                string input = Console.ReadLine();
                string[] split = Regex.Split(input, pattern);
            }
        }
    }
}
