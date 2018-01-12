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
            //lastThing
            //string location = Console.ReadLine();
            //var last = location.LastIndexOf("\\");
            //var fileName = location.Substring(last+1);
            //Console.WriteLine(fileName);

            //replaceThing
            string cocktails = "Berr + Sosage + Coco + Jorjamno";
            string replaced = cocktails.Replace("+", "and");
            Console.WriteLine(replaced);
            //removeThing
            string remove =cocktails.Remove(8,2);
            Console.WriteLine(remove);

        }
    }
}
