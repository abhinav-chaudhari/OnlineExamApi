using OnlineExamAPi.Models;

namespace OnlineExamAPi.Services
{
    public interface IQuestionService
    {
        string AddQuestion(Question question);
        List<Question> GetQuestionsByExam(int ExamId);
    }
}
