namespace QuizApp.Web.Models
{
    public class QuestionViewModel
    {
        public string QuestionDescription { get; set;}
        public int AuthorId { get; set;}
        public int QuizId { get; set;}
        public int QuestionType { get; set;}
        public bool IsActive { get; set;}
    }
}
