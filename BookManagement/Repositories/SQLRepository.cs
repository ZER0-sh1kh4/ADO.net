using BookManagement.Models;
using BookManagement.Data;
namespace BookManagement.Repositories
{
    public class SQLRepository:IBookRepository
    {
        private readonly BookDbContext _context;

        public SQLRepository(BookDbContext context)
        {
            _context = context;
        }

        public List<Book> ListAllBooks()
        {
            return _context.Books.ToList();
        }

        public List<Book> ListByPrice(double price)
        {
            return _context.Books
                   .Where(b => b.Price >= price)
                   .ToList();
        }
        public int BookByName(string name)
        {
            return _context.Books
                   .Count(b => b.Name == name);
        }
    }
}
