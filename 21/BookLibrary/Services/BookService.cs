// Services/BookService.cs
using BookLibrary.Models;
using System.Collections.Generic;

namespace BookLibrary.Services
{
    public class BookService : IBookService
    {
        private static List<Book> _books = new();
        private static int _lastId = 0;

        public IEnumerable<Book> GetAllBooks() => _books;

        public void AddBook(Book book)
        {
            book.Id = ++_lastId;
            _books.Add(book);
        }
    }
}