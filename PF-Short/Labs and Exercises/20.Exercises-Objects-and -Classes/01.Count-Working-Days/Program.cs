using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(start, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(end, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] officialHolyDays = new DateTime[]
            {
                new DateTime(startDate.Year, 1, 1),
                new DateTime(startDate.Year, 3, 3),
                new DateTime(startDate.Year, 5, 1),
                new DateTime(startDate.Year, 5, 6),
                new DateTime(startDate.Year, 5, 24),
                new DateTime(startDate.Year, 9, 6),
                new DateTime(startDate.Year, 9, 22),
                new DateTime(startDate.Year, 11, 1),
                new DateTime(startDate.Year, 12, 24),
                new DateTime(startDate.Year, 12, 25),
                new DateTime(startDate.Year, 12, 26),
            };
            int workingDAys = 0;
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                var day = i.DayOfWeek;
                if (!officialHolyDays.Contains(i)&&!day.Equals(DayOfWeek.Saturday)&& !day.Equals(DayOfWeek.Sunday))
                {
                    workingDAys++;
                }            

            }
            Console.WriteLine(workingDAys);

        }
    }
}
