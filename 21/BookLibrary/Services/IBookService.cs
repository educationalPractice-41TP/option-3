using BookLibrary.Models;
using System.Collections.Generic;

namespace BookLibrary.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        void AddBook(Book book);
    }
}