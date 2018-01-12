using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int numberCount = int.Parse(Console.ReadLine());

            const char letter = 'р';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == letter)
                {
                    hasMatch = true;

                    int endIndex = numberCount+1;

                    if (endIndex +i> text.Length)
                    {

                        endIndex = text.Length - i;
                    }

                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += numberCount;
                }
            }
            
            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
