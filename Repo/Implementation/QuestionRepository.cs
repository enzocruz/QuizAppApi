using Repo.Interfaces;
using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Repo.Interface;
using Microsoft.EntityFrameworkCore;
using Repo.Imp;

namespace Repo.Implementation
{
    public class QuestionRepository : Repository<Quiz>, IQuestion
    {
        public new QuizDB _context;
        public QuestionRepository(QuizDB context)
        :base(context)
        {
            _context = context;
        }

        public IEnumerable<Quiz> GetQuestionsByAuthor(int a_id)
        {
            return _context.Quizzes.Where(x=> x.User!.Id!.Equals(a_id)).ToList();
        }

        public IEnumerable<Quiz> GetQuestionsByDateCreated(DateTime dateTime)
        {
            return _context.Quizzes.Where(x => x.CreatedTime.Equals(dateTime)).ToList();
        }

        public IEnumerable<Quiz> GetQuestionsByIsActive(bool isActive)
        {
            return _context.Quizzes.Where(x => x.IsActive.Equals(isActive)).ToList();
        }
    }
}
