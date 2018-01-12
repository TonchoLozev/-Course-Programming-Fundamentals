using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Library
    {
        public string Name { get; set; }
        public List<Books> Book { get; set; }
    }
    class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string Isbn { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, double> authorAndPrice = new SortedDictionary<string, double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Books book = new Books
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = input[3],
                    Isbn = input[4],
                    Price = double.Parse(input[5])
                };
                if (!authorAndPrice.ContainsKey(book.Author))
                {
                    authorAndPrice.Add(book.Author, book.Price);
                }
                else
                {
                    authorAndPrice[book.Author] += book.Price;
                }
            }
            foreach (var item in authorAndPrice.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }
}
