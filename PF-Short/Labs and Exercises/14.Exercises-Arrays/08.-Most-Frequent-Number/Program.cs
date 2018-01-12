using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] numbers = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();
            ushort checkedNumber = 0;
            ushort theNumber = 0;
            ushort theNumberWeAreChecking=0;
            int len = 0;
            int maxLen = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                
                for (int check = i; check < numbers.Length; check++)
                {
                    if (numbers[i] == checkedNumber)
                    {
                        break;
                    }
                    else
                    {
                        theNumber = (ushort)numbers[i];
                        theNumberWeAreChecking = (ushort)numbers[check];
                        if (theNumber == theNumberWeAreChecking)
                        {
                            len++;
                        }
                    }
                }
                if (len > maxLen)
                {
                    maxLen = len;
                }
                len = 0;
                checkedNumber = (ushort)numbers[i];
            }
            Console.WriteLine(string.Join(" ",numbers[len]));
        }
    }
}
