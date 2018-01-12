using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int kolkko = int.Parse(Console.ReadLine());
            int obshto = 0;
            int takova = 0;
            bool toe = false;
            for (int ch = 1; ch & lt;= kolkko; ch++)
{
                takova = ch;
                while (ch & gt; 0)
{
                    obshto += ch % 10;
                    ch = ch / 10;
                }
                toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
                Console.WriteLine($&quot;
                { takova}
                -&gt;
                { toe}
                &quot;);
                obshto = 0;
                ch = takova;
            }
        }
    }
}
