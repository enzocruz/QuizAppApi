using Repo.Imp;
using Repo.Interface;
using Repo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Repository;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Implementation
{
    public class QuestionOptionReposity : Repository<QuestionOption>, IQuestionOption
    {
        public new QuizDB _context;
        public QuestionOptionReposity(QuizDB context) 
        :base(context) 
        {
            _context = context;
        }

        public IEnumerable<QuestionOption> GetOptionsByQuestion(int q_id)
        {
            return _context.QuestionOptions.Where(x => x.Question.Id.Equals(q_id)).ToList();
        }

        public bool isAnswerCorrect(int q_id, int a_id)
        {
            bool answer = false;
            answer = _context.QuestionOptions.Where(x => x.Question.Id.Equals(q_id) && x.IsAnswer.Equals(1) && x.Id.Equals(a_id)).Any();
            return answer;
        }
    }
}
