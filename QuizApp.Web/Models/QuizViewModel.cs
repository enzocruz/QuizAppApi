namespace QuizApp.Web.Models
{
    public class QuizViewModel
    {
        public int QuizId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public IEnumerable<QuestionViewModel>? Questions { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
