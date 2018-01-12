using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Pokemon_Evolution
{
    class Pokemon
    {
        public string PokemonName { get; set; }
        public List<string> EvolutionType { get; set; }
        public List<int> EvolutionIndex { get; set; }
        public List<KeyValuePair<string, int>> EvoAndIndex { get; set; }
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

                if (split.Length > 1)
                {
                    Pokemon pok = new Pokemon();
                    string pokName = split[0];
                    string evoType = split[1];
                    int evoIndex = int.Parse(split[2]);

                    if (!pokemons.ContainsKey(pokName))
                    {

                        pok.PokemonName = pokName;
                        pok.EvoAndIndex = new List<KeyValuePair<string, int>>();
                        pok.EvoAndIndex.Add(new KeyValuePair<string, int>(evoType, evoIndex));
                        pokemons.Add(pokName, pok);
                    }
                    else
                    {
                        pokemons[pokName].EvoAndIndex.Add(new KeyValuePair<string, int>(evoType, evoIndex));

                    }
                }
                else
                {
                    string pokName = input;
                    if (pokemons.ContainsKey(pokName))
                    {
                        Console.WriteLine("# " + string.Join("", pokemons[pokName].PokemonName));                      
                        for (int i = 0; i < pokemons[pokName].EvoAndIndex.Count; i++)
                        {
                            Console.WriteLine($"{pokemons[pokName].EvoAndIndex[i].Key} <-> {pokemons[pokName].EvoAndIndex[i].Value}");
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine("# "+ pokemon.Key);             
                foreach (var item in pokemon.Value.EvoAndIndex.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{item.Key} <-> {item.Value}");
                }
            }

        }
    }
}
