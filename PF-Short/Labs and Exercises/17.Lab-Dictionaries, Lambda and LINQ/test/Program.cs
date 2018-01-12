using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var phonebook = new Dictionary<string, string>();
            //phonebook["Tonkata"] = "0988747521";
            //phonebook["Tinkata"] = "08888726747";
            //phonebook["Tonkata"] = "new phone";

            //foreach (var item in phonebook)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}
            //var phonebook2 = new SortedDictionary<string, string>();
            //phonebook["Tonkata"] = "0988747521";
            //phonebook["Tinkata"] = "08888726747";
            //phonebook["Tonkata"] = "new phone";

            //foreach (var item in phonebook2)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}
            //var events = new SortedDictionary<DateTime, string>();
            //events[new DateTime(1992, 12, 13)] = "qdoh kibapcheta i kiftenca";
            //foreach (var item in events)
            //{
            //    Console.WriteLine($"{item.Key:dd:MM:yyyy} -> {item.Value}");
            //}
            var list = new List<int> { 20, 30, 40 };
            var result = list.Select(x => );
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
