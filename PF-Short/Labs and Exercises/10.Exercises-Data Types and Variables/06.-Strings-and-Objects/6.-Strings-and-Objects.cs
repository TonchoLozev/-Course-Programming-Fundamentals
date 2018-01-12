using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World";
            object concatenation = a +" " + b;
            int value = (int)(concatenation);
            Console.WriteLine(value);
            Console.WriteLine(concatenation);

        }
    }
}
