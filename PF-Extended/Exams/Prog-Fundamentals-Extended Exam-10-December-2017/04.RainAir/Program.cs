using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RainAir
{
    class Customer
    {
        public string Name { get; set; }
        public List<int> Fligths { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Customer> customers = new Dictionary<string, Customer>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "I believe I can fly!") { break; }

                string[] split = input.Split(' ');

                if (split[1] != "=")
                {
                    string name = split[0];

                    if (!customers.ContainsKey(name))
                    {
                        customers.Add(name, new Customer());

                        customers[name].Fligths = new List<int>();
                        customers[name].Name = name;

                        for (int i = 1; i < split.Length; i++)
                        {
                            customers[name].Fligths.Add(int.Parse(split[i].Trim()));
                        }
                    }
                    else
                    {
                        for (int i = 1; i < split.Length; i++)
                        {
                            customers[name].Fligths.Add(int.Parse(split[i].Trim()));
                        }
                    }
                }

                else
                {
                    string name1 = split[0];
                    string name2 = split[2];

                    customers[name1].Fligths = customers[name2].Fligths;
                }

            }

            foreach (var customer in customers.OrderByDescending(x => x.Value.Fligths.Count).ThenBy(x => x.Value.Name))
            {
                Console.Write($"#{customer.Key} ::: ");
                Console.Write(string.Join(", ", customer.Value.Fligths.OrderBy(x => x)));
                Console.WriteLine();
            }
        }
    }
}
