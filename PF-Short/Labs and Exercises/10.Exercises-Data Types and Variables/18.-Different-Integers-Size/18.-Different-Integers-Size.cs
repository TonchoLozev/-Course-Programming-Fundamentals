using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            try
            {
                if (long.Parse(number) >= long.MinValue && long.Parse(number) <= long.MaxValue)
                {
                    Console.WriteLine($"{number} can fit in: ");
                }                
                try
                {
                    if (sbyte.Parse(number) >= sbyte.MinValue && sbyte.Parse(number) <= sbyte.MaxValue)
                    {
                        Console.WriteLine("* sbyte");
                    }
                }
                catch (Exception)
                {

                }
                try
                {
                    if (byte.Parse(number) >= byte.MinValue && byte.Parse(number) <= byte.MaxValue)
                    {
                        Console.WriteLine("* byte");
                    }
                }
                catch (Exception)
                {

                }
                try
                {
                    if (short.Parse(number) >= short.MinValue && short.Parse(number) <= short.MaxValue)
                    {
                        Console.WriteLine("* short");
                    }
                }
                catch (Exception)
                {

                }
                try
                {
                    if (ushort.Parse(number) >= ushort.MinValue && ushort.Parse(number) <= ushort.MaxValue)
                    {
                        Console.WriteLine("* ushort");
                    }
                }
                catch (Exception)
                {

                }
                try
                {
                    if (int.Parse(number) >= int.MinValue && int.Parse(number) <= int.MaxValue)
                    {
                        Console.WriteLine("* int");
                    }
                }
                catch (Exception)
                {

                }
                try
                {
                    if (uint.Parse(number) >= uint.MinValue && uint.Parse(number) <= uint.MaxValue)
                    {
                        Console.WriteLine("* uint");
                    }
                }
                catch
                {

                }
                try
                {
                    if (long.Parse(number) >= long.MinValue && long.Parse(number) <= long.MaxValue)
                    {
                        Console.WriteLine("* long");
                    }
                }
                catch (Exception)
                {
                  
                }
            }
            catch(Exception)
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}
