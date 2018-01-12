using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_Projects
{
    class Teams
    {
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> container = new Dictionary<string, string>();
            Dictionary<string, Teams> teams = new Dictionary<string, Teams>();
            List<string> joinedMem = new List<string>();

            int loops = int.Parse(Console.ReadLine());

            for (int i = 0; i < loops; i++)
            {
                string input = Console.ReadLine();
                string[] split = input.Split('-');
                string creatorName = split[0];
                string teamName = split[1];

                Teams creatorAndTeam = new Teams();
                creatorAndTeam.Creator = creatorName;
                creatorAndTeam.TeamName = teamName;

                if (container.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (container.ContainsValue(creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");

                teams.Add(teamName, creatorAndTeam);
                container.Add(teamName, creatorName);
                joinedMem.Add(creatorName);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment") { break; }
                string[] split = input.Split('-', '>');
                string name = split[0];
                string clubWanted = split[2];

                Teams team = new Teams();
                team.TeamName = clubWanted;
                team.Members = new List<string>();

                if (!teams.ContainsKey(clubWanted))
                {
                    Console.WriteLine($"Team {clubWanted} does not exist!");
                    continue;
                }

                if (joinedMem.Contains(name))
                {
                    Console.WriteLine($"Member {name} cannot join team {clubWanted}!");
                    continue;
                }

                joinedMem.Add(name);
                if (teams[clubWanted].Members == null)
                {
                    teams[clubWanted].Members = new List<string>();
                    teams[clubWanted].Members.Add(name);
                }
                else
                {
                    teams[clubWanted].Members.Add(name);
                }

            }

            List<string> teamsToDisband = new List<string>();

            foreach (Teams member in teams.Values)
            {
                if (member.Members == null)
                {
                    teamsToDisband.Add(member.TeamName);
                }
            }
            for (int i = 0; i < teamsToDisband.Count; i++)
            {
                teams.Remove(teamsToDisband[i]);
            }

            teams.OrderByDescending(x => x.Value.Members);

            foreach (Teams item in teams.Values.OrderBy(x => x.TeamName))
            {
                Console.WriteLine($"{item.TeamName}");
                Console.WriteLine($"- {item.Creator}");
                for (int i = 0; i < item.Members.Count; i++)
                {
                    Console.WriteLine($"-- {item.Members[i]}");
                }
            }

            Console.WriteLine("Teams to disband: ");

            for (int i = 0; i < teamsToDisband.Count; i++)
            {
                Console.WriteLine(teamsToDisband[i]);
            }

        }
    }
}
