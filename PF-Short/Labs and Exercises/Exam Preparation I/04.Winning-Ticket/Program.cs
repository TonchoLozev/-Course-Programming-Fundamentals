using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
            string pattern = (@"(\@{6,10}|\#{6,10}|\${6,10}|\^{6,10})(?:[^\@\#\$\^]*)\1");
            foreach (var ticket in tickets)
            {
                Match match = Regex.Match(ticket,pattern);
                if (ticket.Length == 20)
                {
                    string matka = match.Groups[1].ToString();
                    if (match.Success)
                    {
                        if (matka.Length < 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matka.Length}{matka.First()}");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matka.Length}{matka.First()} Jackpot!");
                        }
                    }  
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
