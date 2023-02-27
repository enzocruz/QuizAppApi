using Repo.Interfaces;
using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Interface
{
    public interface IQuestionOption : IRepository<QuestionOption>
    {
        IEnumerable<QuestionOption> GetOptionsByQuestion(int q_id);
    }
}
