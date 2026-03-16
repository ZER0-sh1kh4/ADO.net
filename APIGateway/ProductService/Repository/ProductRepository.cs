using ProductService.Data;
using ProductService.Models;

namespace ProductService.Repository
{
    public class ProductRepository :IProductRepository
    {
        private readonly ProductDBContext context;

        public ProductRepository(ProductDBContext db)
        {
            context = db;
        }

        public IEnumerable<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return context.Products.Find(id);
        }

        public void Add(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
    }
}
