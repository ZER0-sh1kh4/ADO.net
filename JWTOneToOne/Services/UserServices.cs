using JWTOneToOne.Data;
using JWTOneToOne.Models;

namespace JWTOneToOne.Services
{
    public class UserServices  :IUserServices
    {
        private readonly AppDbContext _context;

        public UserServices(AppDbContext context)
        {
            _context = context;
        }

        public User Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User Login(string username, string password)
        {
            return _context.Users
            .FirstOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
