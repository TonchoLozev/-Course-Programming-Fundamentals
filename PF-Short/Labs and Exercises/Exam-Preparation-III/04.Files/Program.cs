using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Files
{
    class Files
    {
        public string Directory { get; set; }
        public string File { get; set; }
        public double FileSize { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Files> rootAndFile = new Dictionary<string, Files>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] split = input.Split(';');
                string path = split[0];
                double size = double.Parse(split[1]);

                string[] findExtension = split[0].Split('\\');
                string extension = findExtension[findExtension.Length - 1];


                if (!rootAndFile.ContainsKey(path))
                {
                    rootAndFile.Add(path, new Files());

                    rootAndFile[path].Directory = path;
                    rootAndFile[path].FileSize = size;
                    rootAndFile[path].File = extension;
                }
                else
                {
                    rootAndFile[path].FileSize = size;
                }
            }

            string searching = Console.ReadLine();
            string[] splitSearching = Regex.Split(searching, " in ");
            string root = splitSearching[1] + "\\";
            string ext = "." + splitSearching[0];

            int forgotAboutTheNo = 0;

            var sorted = rootAndFile.OrderByDescending(x => x.Value.FileSize).
                ThenBy(v => v.Value.File);
            foreach (var path in sorted)
            {
                if (path.Key.StartsWith(root) && path.Key.EndsWith(ext))
                {
                    Console.WriteLine($"{path.Value.File} - {path.Value.FileSize} KB");
                }
                else
                {
                    forgotAboutTheNo++;
                }
            }
            if (forgotAboutTheNo == rootAndFile.Count)
            {
                Console.WriteLine("No");
            }
        }
    }
}
