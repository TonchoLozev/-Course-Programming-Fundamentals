using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //var didimonPat = Regex.Match (input, "[^A-Za-z-]+");
            //var bojomon = Regex.Match(input, "[A-Za-z]+-[A-Za-z]+");

            int counter = 1;
            while (true)
            {             
                var didimonPat = Regex.Match(input, "[^A-Za-z-]+");
                var bojomon = Regex.Match(input, "[A-Za-z]+-[A-Za-z]+");
                if (input.Length <= 0)
                {
                    break;
                }
                if (counter % 2 != 0)
                {
                    if(didimonPat.Success)
                    {
                        Console.WriteLine(didimonPat);
                        input = input.Remove(didimonPat.Index, didimonPat.Length);
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if(bojomon.Success)
                    {
                        Console.WriteLine(bojomon);
                        input = input.Remove(0, bojomon.Length);
                    }
                    else
                    {
                        break;
                    }
                }
                counter++;
            }

        }
    }
}
