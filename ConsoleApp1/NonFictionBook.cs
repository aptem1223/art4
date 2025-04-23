using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NonFictionBook : IBook
    {
        public string Title { get; }
        public string Author { get; }
        public string Topic { get; }

        public NonFictionBook(string title, string author, string topic)
        {
            Title = title;
            Author = author;
            Topic = topic;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Научная книга: '{Title}' - {Author} (Тема: {Topic})");
        }
    }
}
