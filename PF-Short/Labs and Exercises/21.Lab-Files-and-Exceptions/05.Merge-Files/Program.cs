using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = File.ReadAllLines("first.txt");
            string[] second = File.ReadAllLines("second.txt");
            File.WriteAllLines("merged.txt", first.Concat(second).OrderBy(x=>x));           
        }
    }
}
