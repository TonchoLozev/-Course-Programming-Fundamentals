using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Pokemon_Evolution
{
    class Pokemon
    {
        public string Name { get; set; }
        public List<KeyValuePair<string, int>> EvolutionTypeAndIndex { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Pokemon> pokemons = new Dictionary<string, Pokemon>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "wubbalubbadubdub") { break; }

                string[] split = Regex.Split(input, " -> ");

                if (split.Length == 3)
                {
                    string pokemonName = split[0].Trim();
                    string evolutionType = split[1].Trim();
                    int evolutionIndex = int.Parse(split[2].Trim());

                    if (!pokemons.ContainsKey(pokemonName))
                    {
                        pokemons.Add(pokemonName, new Pokemon());

                        pokemons[pokemonName].EvolutionTypeAndIndex = new List<KeyValuePair<string, int>>();

                        pokemons[pokemonName].EvolutionTypeAndIndex.Add(new KeyValuePair<string, int>(evolutionType, evolutionIndex));

                    }
                    else
                    {
                        pokemons[pokemonName].EvolutionTypeAndIndex.Add(new KeyValuePair<string, int>(evolutionType, evolutionIndex));

                    }
                }
                else if (split.Length == 1)
                {
                    string pokemonName = split[0].Trim();

                    if (pokemons.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var evolution in pokemons[pokemonName].EvolutionTypeAndIndex)
                        {
                            Console.WriteLine($"{evolution.Key} <-> {evolution.Value}");
                        }
                    }
                }

            }

            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var evolution in pokemon.Value.EvolutionTypeAndIndex.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"{evolution.Key} <-> {evolution.Value}");
                }
            }
        }
    }
}
