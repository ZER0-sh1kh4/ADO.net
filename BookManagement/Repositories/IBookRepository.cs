using BookManagement.Models;

namespace BookManagement.Repositories
{
    public interface IBookRepository
    {
        List<Book> ListAllBooks();
        List<Book> ListByPrice(double price);
        int BookByName(string name);
    }
}
