using JWTOneToOne.DTO;
using JWTOneToOne.Models;
using Microsoft.AspNetCore.Mvc;
using JWTOneToOne.Services;
using JWTOneToOne.DTO;
using JWTOneToOne.Models;

namespace JWTOneToOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserServices _userService;
        private readonly IJwtServices _jwtService;

        public AuthController(IUserServices userService, IJwtServices jwtService)
        {
            _userService = userService;
            _jwtService = jwtService;
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            var result = _userService.Register(user);
            return Ok(result);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto dto)
        {
            var user = _userService.Login(dto.Username, dto.Password);

            if (user == null)
                return Unauthorized();

            var token = _jwtService.GenerateToken(user);

            return Ok(token);
        }
    }
}