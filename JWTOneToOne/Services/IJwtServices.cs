using JWTOneToOne.Models;

namespace JWTOneToOne.Services
{
    public interface IJwtServices
    {
        string GenerateToken(User user);

    }
}
