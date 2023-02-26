using Repo.Imp;
using Repo.Interface;
using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Implementation
{
    public class QuizRepository : Repository<Quiz>, IQuiz
    {
        public new QuizDB _context;
        public QuizRepository(QuizDB context)
            :base(context) 
        {
            _context = context;
        }

        public IEnumerable<Quiz> GetQuizByAuthor(int a_id)
        {
            throw new NotImplementedException();
        }
    }
}
