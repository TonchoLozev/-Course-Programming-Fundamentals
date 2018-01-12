using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string teams = "";
            decimal price = 0;

            for (int i = 0; i < n; i++)
            {
                int distance = int.Parse(Console.ReadLine());
                decimal cargoTons = decimal.Parse(Console.ReadLine());
                string team = Console.ReadLine();

                ulong milesToMeters = (ulong)distance * 1600;
                decimal tonsToKg = cargoTons * 1000m;

                decimal cargoIncome = tonsToKg * 1.5m;
                decimal fuelExpense = 0.7m * milesToMeters * 2.5m;
                decimal sum = cargoIncome - fuelExpense;

                if (team == "Technical" || team == "Theoretical" || team == "Practical")
                {
                    if (i == 0)
                    {
                        price = sum;
                        teams = team;
                    }
                    else
                    {
                        if (sum > price)
                        {
                            price = sum;
                            teams = team;
                        }
                    }
                }

            }

            Console.WriteLine($"The {teams} Trainers win with ${price:F3}.");
        }
    }
}
