using System;
using Xunit;
using LendingLibrary.Classes;

namespace LibraryTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddBook()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            Book book = new Book("Dave's Killer Book", author, Genre.Comedy);

            Library<Book> library = new Library<Book>();
            library.Add(book);
            Assert.Equal(1, library.Count());
        }

        [Fact]
        public void CanRemoveBook()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            Book book = new Book("Dave's Killer Book", author, Genre.Comedy);

            Library<Book> library = new Library<Book>();
            library.Add(book);
            library.Remove(book);
            Assert.Equal(0, library.Count());
        }

        [Fact]
        public void CannotRemoveNonExistantBook()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            Book book = new Book("Dave's Killer Book", author, Genre.Comedy);

            Library<Book> library = new Library<Book>();
            Assert.Throws<Exception>(() => library.Remove(book));
        }

        [Fact]
        public void CanRemoveMultipleOfSameBook()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            Book book = new Book("Dave's Killer Book", author, Genre.Comedy);

            Library<Book> library = new Library<Book>();
            for (int i = 0; i < 10; i++)
            {
                library.Add(book);
            }
            library.Remove(book);
            Assert.Equal(0, library.Count());
        }

        [Fact]
        public void CanGetCount()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            Book book = new Book("Dave's Killer Book", author, Genre.Comedy);

            Library<Book> library = new Library<Book>();
            for (int i = 0; i < 10; i++)
            {
                library.Add(book);
            }

            Assert.Equal(10, library.Count());
        }

        [Fact]
        public void CanSetGenre()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            Book book = new Book("Dave's Killer Book", author, Genre.Comedy);
            book.Genre = Genre.NonFiction;
            Assert.Equal(Genre.NonFiction, book.Genre);
        }

        [Fact]
        public void GanGetGenre()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            Book book = new Book("Dave's Killer Book", author, Genre.Comedy);
            Assert.Equal(Genre.Comedy, book.Genre);
        }

        [Fact]
        public void CanSetAuthor()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            Book book = new Book("Dave's Killer Book", author, Genre.Comedy);
            Author newAuthor = new Author("Hank", "Spain", 1977, 1, 30);
            book.Author = newAuthor;
            Assert.Equal(newAuthor, book.Author);
        }

        [Fact]
        public void CanGetAuthor()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            Book book = new Book("Dave's Killer Book", author, Genre.Comedy);
            Assert.Equal(author, book.Author);
        }

        [Fact]
        public void CanSetTitle()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            Book book = new Book("Dave's Killer Book", author, Genre.Comedy);
            book.Title = "The Killer Book";
            Assert.Equal("The Killer Book", book.Title);
        }

        [Fact]
        public void CanGetTitle()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            Book book = new Book("Dave's Killer Book", author, Genre.Comedy);
            Assert.Equal("Dave's Killer Book", book.Title);
        }

        [Fact]
        public void CanSetName()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            author.Name = "David";
            Assert.Equal("David", author.Name);
        }

        [Fact]
        public void CanGetName()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            Assert.Equal("Dave", author.Name);
        }

        [Fact]
        public void CanSetHomeCountry()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            author.HomeCountry = "France";
            Assert.Equal("France", author.HomeCountry);
        }
        
        [Fact]
        public void CanGetHomeCountry()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            Assert.Equal("Italy", author.HomeCountry);
        }

        [Fact]
        public void CanSetDateOfBirth()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            DateTime newBirthday = new DateTime(1988, 7, 26);
            author.DateOfBirth = newBirthday;
            Assert.Equal(newBirthday, author.DateOfBirth);
        }

        [Fact]
        public void CanGetDateOfBirth()
        {
            Author author = new Author("Dave", "Italy", 1988, 6, 27);
            DateTime dateTime = new DateTime(1988, 6, 27);
            Assert.Equal(dateTime, author.DateOfBirth);
        }
    }
}
