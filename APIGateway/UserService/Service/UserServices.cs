using UserService.Models;
using UserService.Repository;

namespace UserService.Service
{
    public class UserServices
    {
        private readonly IUserRepository repo;

        public UserServices(IUserRepository repository)
        {
            repo = repository;
        }

        public IEnumerable<User> GetUsers()
        {
            return repo.GetAll();
        }
    }
}
