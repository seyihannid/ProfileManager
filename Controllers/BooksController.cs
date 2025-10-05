using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProfileManager.Models;
using System.Reflection;

namespace ProfileManager.Controllers
{
    public class BooksController : Controller
    {
        // GET: BooksController
        public ActionResult Index()
        {
            var books = Book.books;
            return View(books);
        }

        // GET: BooksController/Details/5
        public ActionResult Details(int id)
        {
            var book = Book.books.FirstOrDefault(p => p.Id == id);
            return View(book);
        }

        // GET: BooksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BooksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book model)
        {
            try
            {
                model.Id = Book.books.Max(p => p.Id) + 1;
                Book.books.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksController/Edit/5
        public ActionResult Edit(int id)
        {
            var book = Book.books.FirstOrDefault(p => p.Id == id);
            return View(book);
        }

        // POST: BooksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Book model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var book = Book.books.FirstOrDefault(p => p.Id == id);
                    if (book != null)
                    {
                       book.Title = model.Title;
                       book.Author = model.Author;
                       book.Genre = model.Genre;
                       book.YearPublished = model.YearPublished;
                       book.ISBN = model.ISBN;
                    }
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BooksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var book = Book.books.FirstOrDefault(p => p.Id == id);
                if (book != null)
                {
                    Book.books.Remove(book);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
