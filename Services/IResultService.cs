using OnlineExamAPi.DTOs;

namespace OnlineExamAPi.Services
{
    public interface IResultService
    {
        string SubmitExam(SubmitExamDto dto);
    }
}
