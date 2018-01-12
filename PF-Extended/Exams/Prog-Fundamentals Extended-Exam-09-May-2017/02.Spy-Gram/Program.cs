using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Spy_Gram
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            Dictionary<string, List<string>> pendingMessages = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END") { break; }

                string pattern = @"TO: \w+; MESSAGE: .+";

                Match match = Regex.Match(input, pattern);

                char last = input.Last();

                string[] split = input.Split(' ');

                string name = split[1].Trim();
                name = name.Remove(name.Length - 1);

                if (last == ';' && match.Success && name.All(char.IsUpper))
                {
                    //pendingMessages.Add(name, input);
                    if (!pendingMessages.ContainsKey(name))
                    {
                        pendingMessages.Add(name, new List<string>());
                        pendingMessages[name].Add(input);
                    }
                    else
                    {
                        pendingMessages[name].Add(input);
                    }
                }
            }

            pendingMessages.OrderBy(x => x.Key);
            string digits = key.ToString();

            foreach (var msg in pendingMessages.OrderBy(x=>x.Key))
            {

                foreach (var message in msg.Value)
                {
                    int count = 0;

                    StringBuilder cryptedMsg = new StringBuilder();

                    for (int i = 0; i < message.Length; i++)
                    {
                        if (count >= digits.Length)
                        {
                            count = 0;
                        }
                        int number = int.Parse(digits[count].ToString());

                        int charNumber = message[i] + number;
                        char ch = (char)charNumber;
                        cryptedMsg.Append(ch);
                        count++;
                    }
                    Console.WriteLine(cryptedMsg.ToString());
                }
             
            }
        }
    }
}
