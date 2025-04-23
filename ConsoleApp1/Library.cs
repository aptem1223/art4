using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Library
    {
        private List<IBook> books = new List<IBook>();

        public void AddBook(IBook book)
        {
            books.Add(book);
        }

        public void RemoveBook(IBook book)
        {
            books.Remove(book);
        }

        public void ShowAllBooks()
        {
            Console.WriteLine("\nСписок книг в библиотеке:");
            if (books.Count == 0)
            {
                Console.WriteLine("Библиотека пуста.");
            }
            else
            {
                foreach (var book in books)
                {
                    book.DisplayInfo();
                }
            }
        }
    }
}
