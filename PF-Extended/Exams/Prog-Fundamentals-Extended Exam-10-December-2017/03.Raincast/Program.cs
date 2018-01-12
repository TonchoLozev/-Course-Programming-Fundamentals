using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Raincast
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> texts = new List<string>();

            while (true)
            {
                string breaking = "";

                string input = Console.ReadLine();
                if(input == "Davai Emo") { break; }

                string[] split = input.Split(':');

                string type = split[0].Trim();

                if (type == "Type")
                {
                    string kind = split[1].Trim();

                    if (kind == "Normal" || kind == "Warning" || kind == "Danger")
                    {
                        string whatType = kind;

                        while (true)
                        {
                            if(breaking == "break") { break; }

                            input = Console.ReadLine();
                            if (input == "Davai Emo") { break; }

                            split = input.Split(':');

                            type = split[0].Trim();

                            if (type == "Source")
                            {
                                kind = split[1].Trim();
                                Regex r = new Regex("^[a-zA-Z0-9]*$");

                                if (r.IsMatch(kind))
                                {
                                    string whatSource = kind;

                                    while (true)
                                    {
                                        input = Console.ReadLine();

                                        if (input == "Davai Emo") { break; }

                                        split = input.Split(':');

                                        type = split[0].Trim();

                                        if (type == "Forecast")
                                        {
                                            kind = split[1];

                                            if (!kind.Contains("!") && !kind.Contains(".") && !kind.Contains(",") && !kind.Contains("?"))
                                            {
                                                string whatForecast = kind;

                                                string msg = $"({whatType}){whatForecast} ~ {whatSource}";
                                                texts.Add(msg);
                                                breaking = "break";
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
            foreach (var text in texts)
            {
                Console.WriteLine($"{text}");
            }
        }
    }
}
