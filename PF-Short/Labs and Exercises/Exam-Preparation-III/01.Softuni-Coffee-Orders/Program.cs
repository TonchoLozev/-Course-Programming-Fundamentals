using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                decimal price = ProcesOrders();
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }

        private static decimal ProcesOrders()
        {
            //Capsules
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            decimal capsuleCount = decimal.Parse(Console.ReadLine());

            //Date
            string dateString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateString, "d/M/yyyy", CultureInfo.InvariantCulture);
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
       
            //Price
            decimal priceForTheCoffe = (daysInMonth * capsuleCount) * pricePerCapsule;
            Console.WriteLine($"The price for the coffee is: ${priceForTheCoffe:F2}");
            //Returning the price to sum the total price
            return priceForTheCoffe;
        }
    }
}
