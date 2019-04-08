using System;
using System.Collections.Generic;
using LendingLibrary.Classes;

namespace LendingLibrary
{
    class Program
    {
        /// <summary>
        /// Distributes some library books
        /// </summary>
        /// <param name="library">The library that is distributing books</param>
        static void Borrow(Library<Book> library)
        {
            List<Book> booklist1 = new List<Book>();
            List<Book> booklist2 = new List<Book>();

            int count = 0;

            Console.WriteLine("Books in the library:");
            foreach(Book book in library)
            {
                Console.WriteLine($"{book.Title} by {book.Author.Name}");
                if (count % 2 == 0) booklist1.Add(book);
                else booklist2.Add(book);
                count++;
            }

            Console.WriteLine("\nBooks in list 1:");
            foreach(Book book in booklist1)
            {
                Console.WriteLine($"{book.Title} by {book.Author.Name}");
            }

            Console.WriteLine("\nBooks in list 2:");
            foreach(Book book in booklist2)
            {
                Console.WriteLine($"{book.Title} by {book.Author.Name}");
            }
        }

        static void Main(string[] args)
        {
            Author author1 = new Author("Sarah Brooks", "Canada", 1965, 12, 12);
            Author author2 = new Author("Erik Klein", "Germany", 2012, 6, 1);
            Author author3 = new Author("David Wolfe", "United Kingdom", 1928, 3, 29);

            Book book1 = new Book("The Disappearing Girl", author1, Genre.Thriller);
            Book book2 = new Book("My Dad Is The Coolest", author2, Genre.NonFiction);
            Book book3 = new Book("And Then There Were None", author3, Genre.Horror);
            Book book4 = new Book("The Reappearing Girl", author1, Genre.Thriller);
            Book book5 = new Book("Jokes My Mommy Told Me", author2, Genre.Comedy);
            Book book6 = new Book("Escaping Nazi Germany", author3, Genre.NonFiction);
            Book book7 = new Book("The Redisappearing Girl", author1, Genre.Thriller);
            Book book8 = new Book("The Adventures of Dog McJones in Space", author2, Genre.ScienceFiction);
            Book book9 = new Book("The Love of a Lifetime", author3, Genre.Romance);
            Book book10 = new Book("The Adventures of Dog McJones in Dragonworld", author2, Genre.Fantasy);

            Library<Book> myLibrary = new Library<Book>();
            myLibrary.Add(book1);
            myLibrary.Add(book2);
            myLibrary.Add(book3);
            myLibrary.Add(book4);
            myLibrary.Add(book5);
            myLibrary.Add(book6);
            myLibrary.Add(book7);
            myLibrary.Add(book8);
            myLibrary.Add(book9);
            myLibrary.Add(book10);

            Borrow(myLibrary);

            Console.WriteLine($"\nTotal Books in Library: {myLibrary.Count()}");
            Console.WriteLine($"Adding new book \"The Rereappearing Girl\" to library...");
            Book book11 = new Book("The Rereappearing Girl", author1, Genre.Thriller);
            myLibrary.Add(book11);
            Console.WriteLine($"New Book Total: {myLibrary.Count()}");
            Console.WriteLine($"Removing book \"Jokes My Mommy Told Me\" from the library...");
            myLibrary.Remove(book5);
            Console.WriteLine("\nRe-Running Borrow...");

            Borrow(myLibrary);
        }
    }
}
