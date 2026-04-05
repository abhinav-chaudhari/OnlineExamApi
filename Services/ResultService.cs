using OnlineExamAPi.Data;
using OnlineExamAPi.DTOs;
using OnlineExamAPi.Models;

namespace OnlineExamAPi.Services
{
    public class ResultService : IResultService
    {
        private AppDbContext _appDbContext;

        public ResultService(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }
        public string SubmitExam(SubmitExamDto dto)
        {
            var questions = _appDbContext.Questions
                                         .Where(q=>q.ExamId==dto.ExamId)
                                         .ToList();
            int score = 0;
            foreach (var answer in dto.Answers)
            {
                var question = questions.FirstOrDefault(q => q.Id == answer.QuestionId);

                if(question != null && question.CorrectOption == answer.SelectedOption)
                {
                    score++;
                }
            }

            var result = new Result
            {
                UserId = dto.UserId,
                ExamId = dto.ExamId,
                Score = score,
                TotalQuestions = questions.Count,
                SubmittedAt = DateTime.Now
            };
            _appDbContext.Results.Add(result);
            _appDbContext.SaveChanges();

            return $"Exam submitted. Score: {score}/{questions.Count}";
        }

    }
}
