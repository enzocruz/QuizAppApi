using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Models
{
    public class UserQuestionAnswer
    {
        public int Id { get; set; }
        public User? User { get; set; }
        public Quiz? Question { get; set; }
        public QuestionOption? QuizOption { get; set; }
        public bool isRight { get; set; }
        public DateTime? Created { get; set; } = DateTime.Now;
    }
}