using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            double guests = double.Parse(Console.ReadLine());
            double banans = double.Parse(Console.ReadLine());
            double eggs = double.Parse(Console.ReadLine());
            double berries = double.Parse(Console.ReadLine());

            double sets = guests / 6;
            double setsOfPortions = Math.Ceiling(sets);
            double sumBananas = setsOfPortions * (banans * 2);
            double sumEggs = setsOfPortions * (eggs * 4);
            double sumBeries = setsOfPortions * (berries * 0.2);
            double sum = sumBananas + sumEggs + sumBeries;
            if (sum <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {sum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {sum-cash:F2}lv more.");
            }



        }
    }
}
