using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            DateTime timeLeave = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);
            uint steps = uint.Parse(Console.ReadLine()) % 86400;
            uint secForEachStep = uint.Parse(Console.ReadLine()) % 86400;
            long seconds = steps * secForEachStep;        
            timeLeave = timeLeave.AddSeconds(seconds);
            Console.WriteLine($"Time Arrival: {timeLeave:HH:mm:ss}");
        }
    }
}
