using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            int max = Math.Max(number1.Length, number2.Length);
            int min = Math.Min(number1.Length, number2.Length);

            List<string> sum = new List<string>();
            int carry = 0;
            for (int i = 1; i <= min; i++)
            {
                string last = number1.Substring(number1.Length - i, 1);
                string last2 = number2.Substring(number2.Length - i, 1);
                int summing = int.Parse(last) + int.Parse(last2) + carry;

                if (summing >= 10)
                {
                    summing -= 10;
                    carry = 1;
                    sum.Add(summing.ToString());
                }
                else
                {
                    carry = 0;
                    sum.Add(summing.ToString());
                }
            }
            if (number1.Length > number2.Length)
            {
                number1 = number1.Remove(number1.Length - number2.Length, number2.Length);
                if (carry == 1)
                {
                    string last1 = number1.Substring(number1.Length - 1, 1);
                    int last = int.Parse(last1) + 1;
                    number1 = number1.Remove(number1.Length - 1, 1) + last;

                }
                sum.Add(number1);
            }
            else if (number2.Length > number1.Length)
            {
                number2 = number2.Remove(number2.Length - number1.Length, number1.Length);
                if (carry == 1)
                {
                    string last2 = number2.Substring(number2.Length - 1, 1);
                    int last = int.Parse(last2) + 1;
                    number2 = number2.Remove(number2.Length - 1, 1) + last;

                }
                sum.Add(number2);
            }
            sum.Reverse();

            Console.WriteLine(string.Join("", sum));
        }
    }
}
