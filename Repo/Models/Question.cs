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
        public QuestionType QuestionType { get; set; }
        public Quiz Quiz { get; set; }

    }
}
