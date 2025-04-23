using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            FictionBook fiction = new FictionBook("Мастер и Маргарита", "Михаил Булгаков", "Мистика");
            NonFictionBook nonFiction = new NonFictionBook("Краткая история времени", "Стивен Хокинг", "Космология");
            Textbook textbook = new Textbook("Алгебра, 9 класс", "А. Н. Колмогоров", "Математика");

            library.AddBook(fiction);
            library.AddBook(nonFiction);
            library.AddBook(textbook);

            library.ShowAllBooks();

            Console.WriteLine("\nУдаление художественной книги...\n");
            library.RemoveBook(fiction);

            library.ShowAllBooks();

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
