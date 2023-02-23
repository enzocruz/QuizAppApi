using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionDesc { get; set; }
        public int QuestionTypeId { get; set; }
        public int QuizId { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

    }
}
