using Repo.Imp;
using Repo.Interfaces;
using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Interface
{
    public interface IQuiz : IRepository<Quiz>
    {
        IEnumerable<Quiz> GetQuizByAuthor(int a_id);
    }
}
