/*using Microsoft.AspNetCore.Mvc;
using Atalon.Interfaces;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace Atalon.Controllers
{
  
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IUserService _userService;

        public AuthController(IAuthService authService, IUserService userService)
        {
            _authService = authService;
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest model)
        {
            var success = await _userService.CreateUser(model.Login, model.Password);
            if (!success)
            {
                return Conflict("Такой аккаунт уже существует");
            }

            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest model)
        {
            var token = await _authService.Authenticate(model.Login, model.Password);
            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(new { Token = token });
        }
    }

    public class RegisterRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class LoginRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
*/