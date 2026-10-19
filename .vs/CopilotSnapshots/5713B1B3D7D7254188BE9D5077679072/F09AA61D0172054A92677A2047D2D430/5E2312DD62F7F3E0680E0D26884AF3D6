using Microsoft.AspNetCore.Mvc;
using Bài_1_Tạo_form_và_sử_dụng_các_thuộc_tính_mở_rộng_trên_form.Models;

namespace Bài_1_Tạo_form_và_sử_dụng_các_thuộc_tính_mở_rộng_trên_form.Controllers
{
    public class BookController : Controller
    {
        // Static list to store books in memory
        private static List<Book> bookList = new();
        protected Book book = new Book();

        public BookController()
        {
            // Initialize with default data if empty
            if (bookList.Count == 0)
            {
                bookList = book.GetBookList().ToList();
            }
        }

        public IActionResult Index(int? authorId, int? genreId)
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            ViewBag.selectedAuthorId = authorId;
            ViewBag.selectedGenreId = genreId;

            var books = bookList.AsEnumerable();

            if (authorId.HasValue && authorId > 0)
            {
                books = books.Where(b => b.AuthorId == authorId.Value);
            }

            if (genreId.HasValue && genreId > 0)
            {
                books = books.Where(b => b.GenresId == genreId.Value);
            }

            return View(books.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            Book model = new Book();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Book model)
        {
            if (ModelState.IsValid)
            {
                // Generate new ID
                int newId = bookList.Count > 0 ? bookList.Max(b => b.Id) + 1 : 1;
                model.Id = newId;

                // Handle image upload
                if (model.Image != null && !string.IsNullOrEmpty(model.Image))
                {
                    // Image already handled in form
                }

                bookList.Add(model);
                return RedirectToAction("Index");
            }

            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var editBook = bookList.FirstOrDefault(b => b.Id == id);
            if (editBook == null)
            {
                return NotFound();
            }

            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            return View(editBook);
        }

        [HttpPost]
        public IActionResult Edit(int id, Book model)
        {
            var existingBook = bookList.FirstOrDefault(b => b.Id == id);
            if (existingBook == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                existingBook.Title = model.Title;
                existingBook.AuthorId = model.AuthorId;
                existingBook.GenresId = model.GenresId;
                existingBook.Price = model.Price;
                existingBook.TotalPage = model.TotalPage;

                if (!string.IsNullOrEmpty(model.Image))
                {
                    existingBook.Image = model.Image;
                }

                existingBook.Summary = model.Summary;

                return RedirectToAction("Index");
            }

            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            var deleteBook = bookList.FirstOrDefault(b => b.Id == id);
            if (deleteBook != null)
            {
                bookList.Remove(deleteBook);
            }

            return RedirectToAction("Index");
        }
    }
}
