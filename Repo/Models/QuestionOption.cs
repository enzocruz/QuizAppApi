using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Models
{
    public class QuestionOption
    {
        public int Id { get; set; }
        public string? QuestionOpt { get; set; }
        public int QuestionId { get; set; }
        public bool IsAnswer { get; set; }
        public string? TextAnswer { get; set; }
    }
}
