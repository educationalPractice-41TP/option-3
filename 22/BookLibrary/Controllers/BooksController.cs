using BookLibrary.Models;
using BookLibrary.Services;
using BookLibrary.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookLibrary.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            var books = _bookService.GetAllBooks();
            return View(books);
        }

        public IActionResult Create()
        {
            return View(new BookViewModel { Year = DateTime.Now.Year });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                var book = new Book
                {
                    Title = model.Title,
                    Author = model.Author,
                    ISBN = model.ISBN,
                    Genre = model.Genre,
                    Year = model.Year
                };
                _bookService.AddBook(book);
                TempData["SuccessMessage"] = "Книга успешно добавлена!";
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        public IActionResult Edit(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }

            var model = new BookViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                ISBN = book.ISBN,
                Genre = book.Genre,
                Year = book.Year
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BookViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var existingBook = _bookService.GetBookById(model.Id);
            if (existingBook == null)
                return NotFound();

            existingBook.Title = model.Title;
            existingBook.Author = model.Author;
            existingBook.ISBN = model.ISBN;
            existingBook.Genre = model.Genre;
            existingBook.Year = model.Year;

            _bookService.UpdateBook(existingBook); // Сохраняем изменения через сервис

            TempData["SuccessMessage"] = "Книга успешно обновлена!";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            _bookService.DeleteBook(id);
            TempData["SuccessMessage"] = "Книга удалена!";
            return RedirectToAction(nameof(Index));
        }
    }
}