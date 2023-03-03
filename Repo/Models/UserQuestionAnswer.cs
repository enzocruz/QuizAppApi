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
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public int QuizOptionId { get; set; }
        public bool isRight { get; set; }
        public DateTime? Created { get; set; } = DateTime.Now;
    }
}