using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "gosho", "pesho" };
            File.WriteAllLines("name.txt", names);
            File.AppendAllText("name.txt", "Niki");        
        }
    }
}
