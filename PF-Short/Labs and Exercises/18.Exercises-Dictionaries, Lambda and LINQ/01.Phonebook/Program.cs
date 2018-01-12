using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = true;
            int exist = 0;
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while (end == true)
            {
                string[] functions = Console.ReadLine().Split(' ');
                if (functions[0] == "A")
                {    
                    if(phonebook.Keys.Contains(functions[1]))
                    {
                        phonebook.Remove(functions[1]);
                        phonebook.Add(functions[1], functions[2]);
                    }
                    else
                    {
                        phonebook.Add(functions[1], functions[2]);
                    }
                                    
                }
                else if(functions[0] == "S")
                {
                    if(phonebook.Keys.Contains(functions[1]))
                    {
                        Console.Write($"{functions[1]} -> ");
                        Console.WriteLine(string.Join(" ",phonebook[functions[1]]));
                    }
                    else
                    {
                        Console.WriteLine($"Contact {functions[1]} does not exist.");
                    }
                }
                else if (functions[0] == "END")
                {
                    end = false;
                }
            }


        }
    }
}
