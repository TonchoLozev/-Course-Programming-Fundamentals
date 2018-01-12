using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class testing
    {
        static void Number(int number = 5)
        {
            number = 13;
            Console.WriteLine(number);
        }

        static void Main(string[] args)
        {
            Number();
            Number();
            Number();
        }
    }
}
