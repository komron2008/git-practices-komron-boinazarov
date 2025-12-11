using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Book();
            var b2 = new Book("1984");
            var b3 = new Book("Гарри Поттер", "Дж. Роулинг", 500);

            b1.PrintInfo();
            b2.PrintInfo();
            b3.PrintInfo();
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book()
        {
            Title = "Неизвестное название";
            Author = "Неизвестный автор";
            Pages = 0;
        }

        public Book(string title) : this()
        {
            Title = title;
        }

        public Book(string title, string author) : this(title)
        {
            Author = author;
        }

        public Book(string title, string author, int pages) : this(title, author)
        {
            Pages = pages;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Название: {Title}, Автор: {Author}, Страниц: {Pages}");
        }
    }

}
