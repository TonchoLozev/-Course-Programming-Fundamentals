using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            while (true)
            {
                string msg = Console.ReadLine();

                if (msg == "Traincode!") { break; }

                if (msg.StartsWith("<["))
                {
                    string pattern = @"(<\[(\W*|\D*)\]\.)(\.\[(\w*|\d*)\]\.)*";

                    Match match = Regex.Match(msg, pattern);

                    if(match.Success)
                    {
                        if(match.Length == msg.Length)
                        {
                            Console.WriteLine(msg);
                        }              
                    }

                }            
            }
        }
    }
}
