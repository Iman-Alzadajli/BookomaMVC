using BookomaMVC.Context;
using BookomaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookomaMVC.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var books = _context.Books.ToList();
            return View(books);
        }


        //create 
        [HttpPost]
        public IActionResult Create(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                var book = new Book { Name = name };
                _context.Books.Add(book);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        //delete 
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var book = _context.Books.Find(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        //hide 
        [HttpPost]
        public IActionResult ToggleHide(bool hide)
        {
            var allBooks = _context.Books.ToList();

            foreach (var book in allBooks)
            {
                book.IsHidden = hide;
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
