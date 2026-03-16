using UserService.Data;
using UserService.Models;


namespace UserService.Repository
{
    public class UserRepository :IUserRepository
    {
        private readonly UserDBContext context;

        public UserRepository(UserDBContext db)
        {
            context = db;
        }

        public IEnumerable<User> GetAll()
        {
            return context.Users.ToList();
        }

        public User GetById(int id)
        {
            return context.Users.Find(id);
        }

        public void Add(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
