using JWTRefreshToken.Model;

namespace JWTRefreshToken.Service
{
    public interface ITokenService
    {
        Task<string> GenerateToken(ApplicationUser user);
        string GenerateRefreshToken();

    }
}
