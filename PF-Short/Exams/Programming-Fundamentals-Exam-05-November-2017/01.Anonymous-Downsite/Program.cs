using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int websites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            decimal totalLos = 0;

            List<string> afecteSites = new List<string>();

            for (int i = 0; i < websites; i++)
            {
                string input = Console.ReadLine();
                string[] split = input.Split(' ');

                string siteName = split[0].Trim();
                long siteVisit = long.Parse(split[1].Trim());
                decimal pricePerVisit = decimal.Parse(split[2].Trim());

                afecteSites.Add(siteName);

                decimal siteLos = siteVisit * pricePerVisit;

                totalLos += siteLos;

            }
            int count = afecteSites.Count();
            BigInteger securityToken = BigInteger.Pow(securityKey,count);

            foreach (var site in afecteSites)
            {
                Console.WriteLine(site);
            }
            Console.WriteLine($"Total Loss: {totalLos:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
