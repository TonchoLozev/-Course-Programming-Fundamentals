using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                int day = int.Parse(Console.ReadLine());
                Console.WriteLine(daysOfWeek[day-1]);
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
