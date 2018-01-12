using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Dictionary<string, List<string>> ipOfUser = new Dictionary<string, List<string>>();
            int amount = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                var split = Console.ReadLine().Split(' ');
                string ip = split[0];
                var user = split[1];
                int timeSpent = int.Parse(split[2]);

                if (!dict.ContainsKey(user))
                {
                    dict.Add(user, timeSpent);
                    ipOfUser.Add(user, new List<string> { ip });
                }
                else
                {
                    dict[user] += timeSpent;
                    ipOfUser[user].Add(ip);
                }
            }           
            foreach (var user in dict.OrderBy(x => x.Key))
            {             
                foreach (var item in ipOfUser)
                {
                    if(user.Key==item.Key)
                    {
                        Console.WriteLine($"{user.Key}: {user.Value} ["+string.Join(", ",item.Value.OrderBy(x=>x).Distinct())+"]");                       
                    }                   
                }              
            }
        }
    }
}
