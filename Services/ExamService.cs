using OnlineExamAPi.Data;
using OnlineExamAPi.Models;

namespace OnlineExamAPi.Services
{
    public class ExamService : IExamService
    {
        private readonly AppDbContext _appDbContext;
        
        public ExamService(AppDbContext appDbContext)
        {
           _appDbContext = appDbContext;
        }
        public string CreateExam(Exam exam)
        {
            exam.CreatedAt = DateTime.Now;

            _appDbContext.Exams.Add(exam);
            _appDbContext.SaveChanges();

            return "Exam created Successfully !";
        }
        public List<Exam> GetAllExams() 
        {
            return _appDbContext.Exams.ToList();
        }
    }
}
