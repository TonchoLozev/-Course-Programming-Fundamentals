using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Hint
    {
        static void Main(string[] args)
        {

            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();    //Hint четене на масив от числа      
            //int[] n = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();    //Hint четене на масив от числа с празни места     
            Console.WriteLine(n.Sum());
        }
    }
}
