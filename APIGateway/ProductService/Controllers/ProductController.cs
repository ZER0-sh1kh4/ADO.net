using Microsoft.AspNetCore.Mvc;
using ProductService.Repository;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository repo;

        public ProductController(IProductRepository repository)
        {
            repo = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(repo.GetAll());
        }
    }
}
