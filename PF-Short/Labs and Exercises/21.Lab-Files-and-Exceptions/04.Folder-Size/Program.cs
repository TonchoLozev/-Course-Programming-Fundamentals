using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("TestFolder2");
            double sum = 0;
            foreach (var file in files)
            {
                FileInfo fileinfo = new FileInfo(file);
                double length = fileinfo.Length;
                sum += length;
            }
            sum = sum / 1024 / 1024;
            File.WriteAllText("output.txt", Convert.ToString(sum));
        }
    }
}
