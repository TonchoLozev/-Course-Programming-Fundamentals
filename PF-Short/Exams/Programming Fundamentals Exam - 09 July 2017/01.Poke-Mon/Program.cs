using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            ushort exhaustion = ushort.Parse(Console.ReadLine());

            int firTimePower = pokePower;
            int half = (pokePower * 50) / 100;
            int targetsPoked = 0;
            while (true)
            {

                if (pokePower != half)
                {
                    if (pokePower - distance >= 0)
                    {
                        pokePower -= distance;
                        targetsPoked++;
                    }
                    else
                    {
                        break;
                    }                                       
                    if (pokePower < distance)
                    {
                        break;
                    }

                }
                else
                {
                    if (pokePower / exhaustion != 0)
                    {
                        pokePower /= exhaustion;
                    }
                    else
                    {
                        if (pokePower - distance >= 0)
                        {
                            pokePower -= distance;
                            targetsPoked++;
                        }
                        else
                        {
                            break;
                        }
                    }

                }              
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(targetsPoked);
        }
    }
}
