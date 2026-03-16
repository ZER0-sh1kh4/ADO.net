using UserService.Models;

namespace UserService.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();

        User GetById(int id);

        void Add(User user);
    }
}
