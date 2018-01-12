using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> privateMsg = new List<string>();
            List<string> broadcast = new List<string>();

            int count = 0;
            while (count < 1000)
            {
                string input = Console.ReadLine();
                if (input == "Hornet is Green") { break; }

                string[] split = Regex.Split(input, " <-> ");
                if (split.Length != 2) { continue; }

                string firstQuery = split[0];
                string secondQuery = split[1];

                if (firstQuery.All(char.IsDigit))           //pricate message
                {
                    if (secondQuery.All(char.IsLetterOrDigit))
                    {
                        string recipientCode = firstQuery;
                        string message = secondQuery;
                        StringBuilder reversed = new StringBuilder();

                        char[] charArr = recipientCode.ToCharArray();
                        Array.Reverse(charArr);

                        reversed.Append(charArr);
                        recipientCode = reversed.ToString();

                        privateMsg.Add($"{recipientCode} -> {message}");
                    }
                }
                else if (!firstQuery.All(char.IsDigit))         //broadcast
                {
                    if (secondQuery.All(char.IsLetterOrDigit))
                    {
                        string message = firstQuery;
                        string frequency = secondQuery;
                        StringBuilder appending = new StringBuilder();

                        foreach (char charecter in frequency)
                        {
                            if (Char.IsLetter(charecter))
                            {
                                if (Char.IsLower(charecter))
                                {
                                    string toUpp = charecter.ToString().ToUpper();
                                    appending.Append(toUpp);
                                }
                                else
                                {
                                    string toLow = charecter.ToString().ToLower();
                                    appending.Append(toLow);
                                }
                            }
                            else
                            {
                                appending.Append(charecter.ToString());
                            }
                        }
                        frequency = appending.ToString();
                        broadcast.Add($"{frequency} -> {message}");
                    }
                }
                else
                {
                    continue;
                }

                count++;
            }

            Console.WriteLine("Broadcasts:");
            if (broadcast.Count > 0)
            {
                foreach (var cast in broadcast)
                {
                    Console.WriteLine(cast);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (privateMsg.Count > 0)
            {
                foreach (var msg in privateMsg)
                {
                    Console.WriteLine(msg);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
