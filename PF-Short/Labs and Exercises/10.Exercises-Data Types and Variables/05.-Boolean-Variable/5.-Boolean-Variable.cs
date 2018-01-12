using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool trueOrFalse = Convert.ToBoolean(Console.ReadLine());
            
            if(trueOrFalse == true)
            {
                Console.WriteLine("Yes" );
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
