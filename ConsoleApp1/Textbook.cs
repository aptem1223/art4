using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Textbook : IBook
    {
        public string Title { get; }
        public string Author { get; }
        public string Subject { get; }

        public Textbook(string title, string author, string subject)
        {
            Title = title;
            Author = author;
            Subject = subject;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Учебник: '{Title}' - {Author} (Предмет: {Subject})");
        }
    }
}
