﻿using Repo.Interfaces;
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
using System.Data.Entity;

namespace Repo.Implementation
{
    public class QuestionRepository : Repository<Question>, IQuestion
    {
        public new QuizDB _context;
        public QuestionRepository(QuizDB context)
        :base(context)
        {
            _context = context;
        }

        public IEnumerable<Question> GetQuestionsByAuthorQuiz(int q_id, int a_id)
        {
            return _context.Questions.Where(x => x.QuizId.Equals(q_id) && x.UserId.Equals(a_id)).ToList();
        }

        public IEnumerable<Question> GetQuestionsByDateCreated(DateTime dateTime)
        {
            return _context.Questions.Where(x => x.DateCreated.Equals(dateTime)).ToList();
        }

        public IEnumerable<Question> GetQuestionsByIsActive(bool isActive)
        {
            return _context.Questions.Where(x => x.IsActive.Equals(isActive)).ToList();
        }

        public bool isCorrectAnswer(int q_id, int a_id)
        {
            bool answer = false;
            answer = _context.QuestionOptions.Where(x => x.QuestionId.Equals(q_id) && x.IsAnswer.Equals(1) && x.Id.Equals(a_id)).Any();
            return answer;
        }

        public  bool isDuplicate(string desc)
        {
            return  _context.Questions.Where(x => x.QuestionDesc.ToLower().Equals(desc.ToLower())).Any();
        }
    }
}
