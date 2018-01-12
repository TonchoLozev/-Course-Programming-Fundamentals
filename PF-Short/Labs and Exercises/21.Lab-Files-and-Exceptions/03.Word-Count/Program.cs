using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("text.txt").
                ToLower().
                Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries).
                ToArray();
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            foreach (var word in text)
            {
                if(!wordCount.ContainsKey(word))
                {
                    wordCount.Add(word, 1);
                }
                else
                {
                    wordCount[word]++;
                }
            }
            wordCount.OrderByDescending(x => x.Value);
            File.WriteAllText("result.txt", "");
            foreach (var item in wordCount.OrderByDescending(x=>x.Value))
            {
                if(words.Contains(item.Key))
                {
                    File.AppendAllText("result.txt", item.Key + " -> " + item.Value + Environment.NewLine);
                }
            }
        }
    }
}
