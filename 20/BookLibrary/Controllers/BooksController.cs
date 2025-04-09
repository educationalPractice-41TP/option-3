// Controllers/BooksController.cs
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Controllers
{
    public class BooksController : Controller
    {
        private static List<Book> books = new List<Book>();
        private static int lastId = 0;

        public ActionResult Index()
        {
            return View(books);
        }

        public ActionResult Details(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                book.Id = ++lastId;
                books.Add(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }
    }
}