using ProductService.Models;
using ProductService.Repository;

namespace ProductService.Service
{
    public class ProductServices
    {
        private readonly IProductRepository repo;

        public ProductServices(IProductRepository repository)
        {
            repo = repository;
        }

        public IEnumerable<Product> GetProducts()
        {
            return repo.GetAll();
        }
    }
}
