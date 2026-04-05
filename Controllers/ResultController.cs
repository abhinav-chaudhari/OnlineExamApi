using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineExamAPi.DTOs;
using OnlineExamAPi.Services;

namespace OnlineExamAPi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResultController : ControllerBase
    {

        private readonly IResultService _resultService;

        public ResultController(IResultService resultService)
        {
            _resultService = resultService;
        }
        [Authorize]
        [HttpPost("Submit")]
        public IActionResult SubmitExam([FromBody] SubmitExamDto dto)
        {
            var result = _resultService.SubmitExam(dto);
            return Ok(result);
        }
    }
}
