namespace OnlineExamAPi.Models
{
    public class Exam
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int DurationMinutes { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
