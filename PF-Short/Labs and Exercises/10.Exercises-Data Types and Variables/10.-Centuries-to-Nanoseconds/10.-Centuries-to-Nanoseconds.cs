using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = (long)(hours * 60);
            long seconds = minutes * 60;
            long miliseconds = seconds * 1000;
            ulong microsends =(ulong) (miliseconds * 1000);
            ulong nanoseconds = microsends * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microsends} microseconds = {nanoseconds} nanoseconds ");
        }
    }
}
