using BookManagement.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _repo;

        public BookController(IBookRepository repo)
        {
            _repo = repo;
        }

        public IActionResult ListAllBooks()
        {
            var books = _repo.ListAllBooks();

            string result = "";

            foreach (var b in books)
            {
                result += b.Id + " " + b.Name + " " + b.Author + " " + b.Price + "\n";
            }

            return Content(result);
        }
        public IActionResult ListByPrice(double price)
        {
            var books = _repo.ListByPrice(price);

            string result = "";

            foreach (var b in books)
            {
                result += b.Id + " " + b.Name + " " + b.Author + " " + b.Price + "\n";
            }

            return Content(result);
        }
        public IActionResult BookByName(string name)
        {
            int count = _repo.BookByName(name);
            return Content("Total Books = " + count);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
