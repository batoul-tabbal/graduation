using grade.LogIn;
using grade.Services;
using Microsoft.AspNetCore.Mvc;

namespace grade.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService;

        public AuthController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
           
            if (user.Username == "admin" && user.Password == "password")
            {
                var token = _tokenService.GenerateToken(user.Username);
                return Ok(new LogInResponse { Token = token });
            }

            return Unauthorized();
        }
    }
}
