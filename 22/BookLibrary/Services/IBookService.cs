// Services/IBookService.cs
using BookLibrary.Models;
using System.Collections.Generic;

namespace BookLibrary.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book? GetBookById(int id); // Добавляем nullable тип
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}