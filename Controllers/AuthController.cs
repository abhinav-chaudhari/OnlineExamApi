using Microsoft.AspNetCore.Mvc;
using OnlineExamAPi.DTOs;
using OnlineExamAPi.Models;
using OnlineExamAPi.Services;

namespace OnlineExamAPi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            var result =   _authService.Register(user);
            return Ok(result);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto dto)
        {
            var token = _authService.Login(dto.Email, dto.Password);
            return Ok(token);
        }
    }
}
