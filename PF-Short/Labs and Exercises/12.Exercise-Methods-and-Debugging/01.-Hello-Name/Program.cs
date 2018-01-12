using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            RecieveName(name);
        }
        static string RecieveName(string readName)
        {
            Console.WriteLine($"Hello, {readName}!");
            return readName;
        }
    }
}
