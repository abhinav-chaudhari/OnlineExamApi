using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineExamAPi.Models;
using OnlineExamAPi.Services;

namespace OnlineExamAPi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IUserService _userService;

        public TestController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("add-user")]
        public IActionResult AddUser()
        {
            var user = new User
            {
                Name = "Abhinav",
                Email = "test@mail.com",
                PasswordHash = "123",
                Role = "Student"
            };

            var result = _userService.AddUser(user);

            return Ok(result);
        }

        [Authorize]
        [HttpGet("secure")]
        public IActionResult Secure()
        {
            return Ok("You are authorized 🔐");
        }
    }
}