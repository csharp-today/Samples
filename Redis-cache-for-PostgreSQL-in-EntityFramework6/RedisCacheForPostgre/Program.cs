using RedisCacheForPostgre.Entities;
using System;
using System.Linq;

namespace RedisCacheForPostgre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //InsertSampleData();
            PrintBooks();
        }

        private static void InsertSampleData()
        {
            using (var context = new PostgreContext())
            {
                context.Book.Add(new Book { Title = "Witcher", Author = "Andrzej Sapkowski" });
                context.Book.Add(new Book { Title = "A Game of Thrones", Author = "George R.R. Martin" });
                context.Book.Add(new Book { Title = "Inclusion", Author = "Andrzej W. Sawicki" });
                context.SaveChanges();
            }
        }

        private static void PrintBooks()
        {
            using (var context = new PostgreContext())
            {
                var books = context.Book.ToList();

                foreach (var book in books)
                {
                    Console.WriteLine($"  '{book.Title}' by {book.Author}");
                }
            }
        }
    }
}
