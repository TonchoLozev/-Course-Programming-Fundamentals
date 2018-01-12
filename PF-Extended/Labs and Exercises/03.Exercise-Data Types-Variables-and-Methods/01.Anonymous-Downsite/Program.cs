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
            int n = int.Parse(Console.ReadLine());
            int key = int.Parse(Console.ReadLine());


            List<string> sites = new List<string>();
            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string site = input[0];
                long visits = long.Parse(input[1]);
                decimal price = decimal.Parse(input[2]);

                sum += price*visits;
                sites.Add(site);
            }
            Console.WriteLine(string.Join("\r\n", sites));
            Console.WriteLine($"Total Loss: {sum:F20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(key,sites.Count)}");
        }
    }
}
