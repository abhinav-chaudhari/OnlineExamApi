using OnlineExamAPi.Models;

namespace OnlineExamAPi.Services
{
    public interface IExamService
    {
        string CreateExam(Exam exam);
        List<Exam> GetAllExams();
    }
}
