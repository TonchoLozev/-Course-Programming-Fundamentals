using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> privateMessages = new List<string>();
            List<string> broadcasts = new List<string>();
            int count = 0;
            while (count<1000)
            {
                string input = Console.ReadLine();
                if (input == "Hornet is Green" || count>1000) { break; }
                string[] inputSplit = Regex.Split(input, " <-> ");
                if (inputSplit.Length != 2) { continue; }
                string firstQuery = inputSplit[0];
                string secondQuery = inputSplit[1];
                if (firstQuery.All(char.IsDigit) && (secondQuery.All(char.IsLetter) || secondQuery.All(char.IsLetterOrDigit)))
                {
                    StringBuilder reverseFirstQuery = new StringBuilder(); //it was rly hard

                    char[] charArr = firstQuery.ToCharArray();
                    charArr = charArr.Reverse().ToArray();         //how to revers like a noob         
                    reverseFirstQuery.Append(charArr);

                    string addingMessage = $"{reverseFirstQuery} -> {secondQuery}";
                    privateMessages.Add(addingMessage);
                }
                else if ((!firstQuery.All(char.IsDigit)) && (secondQuery.All(char.IsDigit) || secondQuery.All(char.IsLetterOrDigit)))
                {
                    StringBuilder toUpperAndLower = new StringBuilder();
                    foreach (char charecter in secondQuery)
                    {
                        if ((!Char.IsDigit(charecter)) && (!Char.IsSymbol(charecter)))
                        {
                            if (Char.IsLower(charecter))
                            {
                                toUpperAndLower.Append(charecter.ToString().ToUpper());
                            }
                            else if (Char.IsUpper(charecter))
                            {
                                toUpperAndLower.Append(charecter.ToString().ToLower());                             
                            }
                        }
                        else
                        {
                            toUpperAndLower.Append(charecter);
                        }
                    }
                    string addingMessage = $"{toUpperAndLower} -> {firstQuery}";
                    broadcasts.Add(addingMessage);
                }
                count++;
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count > 0)
            {
                foreach (var cast in broadcasts)
                {
                    Console.WriteLine($"{cast}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (privateMessages.Count > 0)
            {
                foreach (var message in privateMessages)
                {
                    Console.WriteLine($"{message}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }

        }
    }
}
