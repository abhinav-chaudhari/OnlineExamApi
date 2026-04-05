using Microsoft.AspNetCore.Mvc;
using OnlineExamAPi.Services;
using OnlineExamAPi.Models;
using Microsoft.AspNetCore.Authorization;

namespace OnlineExamAPi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
        [Authorize]
        [HttpPost("add")]
        public IActionResult AddQuestion(Question question)
        {
            var result = _questionService.AddQuestion(question);
            return Ok(result);
        }
        [Authorize]
        [HttpPost("by-exam/{examId}")]
        public IActionResult GetByExam(int examId)
        {
            var questions = _questionService.GetQuestionsByExam(examId);
            return Ok(questions);
        }
    }
}
