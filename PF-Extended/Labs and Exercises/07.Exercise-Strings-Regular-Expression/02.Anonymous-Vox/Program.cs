using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder edit = new StringBuilder(text);

            string[] replaceValues = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"([A-Za-z]+)(.*)(\1)";

            Match match = Regex.Match(text, pattern);

            if (match.Success)
            {
                int count = 0;
                foreach (Match m in Regex.Matches(text, pattern))
                {
                    string replacing = m.Groups[2].ToString();
                    int index = int.Parse(m.Groups[2].Index.ToString());


                    text = text.Replace(replacing, replaceValues[count]);
                    count++;
                }
            }
            Console.WriteLine(text);
        }
    }
}
