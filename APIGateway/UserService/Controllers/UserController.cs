using Microsoft.AspNetCore.Mvc;
using UserService.Repository;

namespace UserService.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository repo;

        public UserController(IUserRepository repository)
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
