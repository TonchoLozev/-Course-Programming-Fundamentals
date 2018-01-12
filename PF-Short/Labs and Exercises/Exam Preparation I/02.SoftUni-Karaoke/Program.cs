using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Player
    {
        public string Name { get; set; }
        public int AwardsCount { get; set; }
        public List<string> Awards { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<string> participants = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
            List<string> songs = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
            Dictionary<string, Player> paricipantAndAward = new Dictionary<string, Player>();

            while (true)
            {
                string read = Console.ReadLine();
                if (read == "dawn") { break; }

                string[] split = read.Split(',').Select(x => x.Trim()).ToArray();
                string participant = split[0];
                string song = split[1];
                string award = split[2];

                if (participants.Contains(participant) && songs.Contains(song))
                {
                    if (!paricipantAndAward.ContainsKey(participant))
                    {
                        Player player = new Player();
                        player.Awards = new List<string>();
                        player.Name = participant;
                        player.AwardsCount++;
                        player.Awards.Add(award);

                        paricipantAndAward.Add(participant, player);
                    }
                    else
                    {
                        if (!paricipantAndAward[participant].Awards.Contains(award))
                        {
                            paricipantAndAward[participant].AwardsCount++;
                            paricipantAndAward[participant].Awards.Add(award);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
            if (paricipantAndAward.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var player in paricipantAndAward.OrderByDescending(x => x.Value.AwardsCount).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{player.Key}: {player.Value.AwardsCount} awards");
                    foreach (var award in player.Value.Awards.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }        
        }
    }
}
