﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] badWords = Console.ReadLine().Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();
            foreach (var word in badWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
