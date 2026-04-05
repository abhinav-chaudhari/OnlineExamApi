using Microsoft.AspNetCore.Mvc;
using OnlineExamAPi.Services;
using OnlineExamAPi.Models;
using Microsoft.AspNetCore.Authorization;

namespace OnlineExamAPi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExamController : ControllerBase
    {

        private readonly IExamService _examService;

        public ExamController(IExamService examService)
        {
            _examService = examService;
        }
        [Authorize]
        [HttpPost("create")]
        public IActionResult CreateExam(Exam exam)
        {
            var result = _examService.CreateExam(exam);
            return Ok(result);
        }
        [Authorize]
        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var exams = _examService.GetAllExams();
            return Ok(exams);
        }
    }
}
