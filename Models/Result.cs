namespace OnlineExamAPi.Models
{
    public class Result
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ExamId { get; set; }

        public int Score { get; set; }

        public int TotalQuestions { get; set; }

        public DateTime SubmittedAt { get; set; }
    }
}
