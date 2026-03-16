using JWTOneToOne.Models;

namespace JWTOneToOne.Services
{
    public interface IUserServices
    {
        User Register(User user);
        User Login(string username, string password);
    }
}
