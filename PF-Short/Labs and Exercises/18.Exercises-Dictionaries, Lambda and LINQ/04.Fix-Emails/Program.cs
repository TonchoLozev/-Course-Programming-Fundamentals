using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailsDict = new Dictionary<string, string>();
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();

                emailsDict[name] = email;
            }
            foreach (var item in emailsDict)
            {
                if (!item.Value.Contains("us") || !item.Value.Contains("uk"))
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }

            }
        }
    }
}
