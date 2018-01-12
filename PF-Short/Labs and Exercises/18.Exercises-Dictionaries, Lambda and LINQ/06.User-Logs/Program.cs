using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> user = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                var commandArgs = input.Split('=', ' ');
                string ip = commandArgs[1];
                var userName = commandArgs[5];
                if (!user.ContainsKey(userName))
                {
                    user.Add(userName, new Dictionary<string, int>());
                }
                if (!user[userName].ContainsKey(ip))
                {
                    user[userName].Add(ip, 0);
                }
                user[userName][ip] += 1;
                input = Console.ReadLine();
            }
            foreach (var item in user)
            {
                Console.WriteLine($"{item.Key}: ");
                foreach (var log in item.Value)
                {
                    if (log.Key != item.Value.Keys.Last())
                    {
                        Console.Write($"{log.Key} => {log.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{log.Key} => {log.Value}.");
                    }
                }
            }
        }
    }
}
