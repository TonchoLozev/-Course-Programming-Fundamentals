using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {           
            DateTime dateParsing = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy",CultureInfo.InvariantCulture);
            Console.WriteLine(dateParsing.DayOfWeek);
        }
    }
}
