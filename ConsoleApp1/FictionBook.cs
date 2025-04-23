using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FictionBook : IBook
    {
        public string Title { get; }
        public string Author { get; }
        public string Genre { get; }

        public FictionBook(string title, string author, string genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Художественная книга: '{Title}' - {Author} (Жанр: {Genre})");
        }
    }
}
