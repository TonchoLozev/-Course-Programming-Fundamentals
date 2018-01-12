using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            uint wingFlaps = uint.Parse(Console.ReadLine()); //wing flaps
            double meters = double.Parse(Console.ReadLine()); //meteres the hornet travels for 1000 wing flaps
            uint endurance = uint.Parse(Console.ReadLine()); // wing flaps before rest (rest is 5 seconds)
            //hornet can make 100 wing flaps per second
            //calc the distance and how much time it took him(distance in meters)(time in seconds)
            double distance = (wingFlaps / 1000) * meters; // distnace

            uint horneFlaps = wingFlaps / 100;
            uint rests = (wingFlaps / endurance) * 5;
            uint sum = horneFlaps + rests; //amount of time it took him 
            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{sum} s.");

        }
    }
}
