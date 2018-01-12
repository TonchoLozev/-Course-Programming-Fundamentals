using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> listOfNums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            bool isThereSum = true;           
            while (isThereSum == true)
            {
                isThereSum = false;
                decimal sum = 0;
                int index = 0;
                for (int i = 1; i <= listOfNums.Count - 1; i++)
                {
                    if (listOfNums[i] == listOfNums[i - 1])
                    {
                        index = i - 1;
                        sum = listOfNums[i] + listOfNums[i - 1];
                        isThereSum = true;
                        break;
                    }
                }
                if (isThereSum == true)
                {
                    listOfNums.RemoveRange(index, 2);
                    listOfNums.Insert(index, sum);
                }
            }
            Console.WriteLine(string.Join(" ",listOfNums));
        }
    }
}
