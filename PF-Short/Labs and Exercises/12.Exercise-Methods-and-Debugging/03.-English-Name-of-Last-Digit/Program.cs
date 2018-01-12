using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string lastNumber = "";
            string lastDigit = GetLastDigit(number,lastNumber);
            Console.WriteLine(lastDigit);
        }
        static string GetLastDigit(long digit,string lastNumber)
        {
            long number = digit;
            long lastDigit = Math.Abs(digit % 10);
            string last = "";
            switch (lastDigit)
            {
                case 0:
                    last = "zero";
                    break;
                case 1:
                    last = "one";
                    break;
                case 2:
                    last = "two";
                    break;
                case 3:
                    last = "three";
                    break;
                case 4:
                    last = "four";
                    break;
                case 5:
                    last = "five";
                    break;
                case 6:
                    last = "six";
                    break;
                case 7:
                    last = "seven";
                    break;
                case 8:
                    last = "eight";
                    break;
                case 9:
                    last = "nine";
                    break;
                default:                    
                    break;
            }
            return last;
        }
    }
}
