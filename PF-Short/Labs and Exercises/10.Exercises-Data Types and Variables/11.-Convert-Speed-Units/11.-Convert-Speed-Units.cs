using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float timeSeconds = (hours * 3600 + minutes * 60 + seconds);
            float metersPerSEcond = (distance / timeSeconds);
            float kilometersPerHours = (float)(metersPerSEcond * 3.60);
            float milesPerHours = (float)(kilometersPerHours / 1.609);


            Console.WriteLine($"{metersPerSEcond}");
            Console.WriteLine($"{kilometersPerHours}");
            Console.WriteLine($"{milesPerHours}");
        }
    }
}
