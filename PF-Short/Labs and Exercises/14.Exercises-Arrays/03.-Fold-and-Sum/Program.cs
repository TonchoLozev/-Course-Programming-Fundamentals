using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrayOfFirstElements = FirstKNumbers(integers);
            int[] arrayOfLastElements = LastKNumber(integers);
            int[] sum = arrayOfFirstElements.Concat(arrayOfLastElements).ToArray();
            int[] removedIntegers = RemovingTheDigits(integers);
            int[] sumOfArrays = new int[sum.Length];
            for (int i = 0; i < sum.Length; i++)
            {
                sumOfArrays[i] = sum[i] + removedIntegers[i];
            }
            Console.WriteLine(string.Join(" ", sumOfArrays));

        }

        static int[] FirstKNumbers(int[] firstNumbers)
        {
            int[] numbers = new int[firstNumbers.Length / 4];
            int counter = 0;
            for (int i = firstNumbers.Length / 4; i > 0; i--)
            {
                numbers[i - 1] = firstNumbers[counter];
                counter++;
            }
            return numbers;
        }

        static int[] LastKNumber(int[] lastNumbers)
        {
            int[] numbers = new int[lastNumbers.Length / 4];
            int counter = lastNumbers.Length - 1;
            for (int i = 0; i < lastNumbers.Length / 4; i++)
            {
                numbers[i] = lastNumbers[counter];
                counter--;
            }
            return numbers;
        }

        static int[] RemovingTheDigits(int[] arrayToRemoveDigits)
        {
            int[] arrayOfTheFirstHalf = new int[arrayToRemoveDigits.Length / 4];
            int counter = 0;
            for (int i = 1; i <= arrayToRemoveDigits.Length / 2; i++)
            {
                if (i > arrayToRemoveDigits.Length / 4)
                {
                    arrayOfTheFirstHalf[counter] += arrayToRemoveDigits[i - 1];
                    counter++;
                }
            }

            int[] arrayOfTheLastHalf = new int[arrayToRemoveDigits.Length / 4];
            int counter2 = 0;
            for (int i = arrayToRemoveDigits.Length / 2; i <= arrayToRemoveDigits.Length; i++)
            {
                if (counter2 < arrayToRemoveDigits.Length / 4)
                {
                    arrayOfTheLastHalf[counter2] = arrayToRemoveDigits[i];
                    counter2++;
                }
            }
            int[] sum = arrayOfTheFirstHalf.Concat(arrayOfTheLastHalf).ToArray();
            return sum;
        }
    }
}

