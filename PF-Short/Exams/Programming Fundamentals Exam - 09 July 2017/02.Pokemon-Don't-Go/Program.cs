using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            long sum = 0;
            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int removed = 0;

                if (index < 0)
                {
                    removed = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                    sum += removed;
                }
                else if (index > pokemons.Count-1)
                {
                    removed = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                    sum += removed;
                }
                else
                {
                    removed = pokemons[index];
                    pokemons.RemoveAt(index);
                    sum += removed;
                }
                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= removed)
                    {
                        pokemons[i] += removed;
                    }
                    else
                    {
                        pokemons[i] -= removed;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
