using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _06.Book_Library_Modification
{
    class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Isbn { get; set; }
        public double Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, DateTime> titleAndReleaseDate = new SortedDictionary<string, DateTime>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Books book = new Books
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    Isbn = input[4],
                    Price = double.Parse(input[5])
                };
                if(!titleAndReleaseDate.ContainsKey(book.Title))
                {
                    titleAndReleaseDate.Add(book.Title, book.ReleaseDate);
                }
                else
                {
                    titleAndReleaseDate[book.Title] = book.ReleaseDate;
                }
            }
            string givenDate = Console.ReadLine();
            DateTime after = DateTime.ParseExact(givenDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            foreach (var item in titleAndReleaseDate.OrderBy(x=>x.Value).ThenBy(x=>x.Key).Where(x=>x.Value>after))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:dd.MM.yyyy}");
            }
        }
    }
}
