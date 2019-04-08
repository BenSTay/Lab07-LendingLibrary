using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Classes
{
    public class Library<T> : IEnumerable
    {
        private T[] _books = new T[8];
        private int _count = 0;

        /// <summary>
        /// Adds an item to the library.
        /// </summary>
        /// <param name="book">The item being added.</param>
        public void Add(T book)
        {
            if (_count == _books.Length)
            {
                Array.Resize(ref _books, _books.Length + 8);
            }
            _books[_count++] = book;
        }

        /// <summary>
        /// Removes all elements in the library that match a given item.
        /// </summary>
        /// <param name="book">The item being removed.</param>
        public void Remove(T book)
        {
            T[] temp = _books;
            int tempcount = _count;
            _books = new T[8];
            _count = 0;
            for (int i = 0; i < tempcount; i++)
            {
                if (!temp[i].Equals(book))
                {
                    Add(temp[i]);
                }
            }
            if (_count == tempcount)
            {
                throw new Exception("Book was not found in the library!");
            }
        }

        /// <summary>
        /// Gets the current item count.
        /// </summary>
        /// <returns>The current item count.</returns>
        public int Count()
        {
            return _count;
        }

        /// <summary>
        /// Gets each item in the library.
        /// </summary>
        /// <returns>Each item in the library.</returns>
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _books[i];
            }
        }

        /// <summary>
        /// Magic, don't touch.
        /// </summary>
        /// <returns>Each item in the library.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
