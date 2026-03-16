using BookManagement.Models;
namespace BookManagement.Repositories
{
    public class BookRepository: IBookRepository
    {
        Dictionary<int, Book> books = new Dictionary<int, Book>();

        public BookRepository()
        {
            books.Add(1, new Book { Id = 1, Name = "CSharp", Author = "John", Price = 500 });
            books.Add(2, new Book { Id = 2, Name = "Java", Author = "Mike", Price = 400 });
            books.Add(3, new Book { Id = 3, Name = "Python", Author = "Sara", Price = 600 });
            books.Add(4, new Book { Id = 4, Name = "CSharp", Author = "Tom", Price = 450 });
        }

        public List<Book> ListAllBooks()
        {
            return books.Values.ToList();
        }
        public List<Book> ListByPrice(double price)
        {
            return books.Values.Where(b => b.Price >= price).ToList();
        }

        public int BookByName(string name)
        {
            return books.Values.Count(b => b.Name == name);
        }
    }
}
