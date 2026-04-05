using OnlineExamAPi.Data;
using OnlineExamAPi.Models;

namespace OnlineExamAPi.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly AppDbContext _appdbcontext;

        public QuestionService(AppDbContext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }
        public string AddQuestion(Question question)
        {
            _appdbcontext.Questions.Add(question);
            _appdbcontext.SaveChanges();

            return "Question Added Successfully !";
        }
        public List<Question> GetQuestionsByExam(int examId)
        {
            return _appdbcontext.Questions
                                .Where(q =>  q.ExamId == examId)
                                .ToList();
        }
    }
}
