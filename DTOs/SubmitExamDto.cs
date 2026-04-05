

namespace OnlineExamAPi.DTOs
{
    public class SubmitExamDto
    {
        public int UserId { get; set; }

        public int ExamId { get; set; }

        public List<AnswerDto> Answers { get; set; }
    }
    public class AnswerDto
    {
        public int QuestionId { get; set; }

        public string SelectedOption { get; set; }
    }
}
