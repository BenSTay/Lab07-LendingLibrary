using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Classes
{
    public enum Genre
    {
        ScienceFiction,
        Fantasy,
        Horror,
        Romance,
        Thriller,
        Comedy,
        NonFiction
    }
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }

        public Book(string title, Author author, Genre genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }
    }
}
