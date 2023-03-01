using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace Repo.Interfaces;

public interface IQuestion : IRepository<Question>
{
    IEnumerable<Question> GetQuestionsByDateCreated(DateTime dateTime);
    IEnumerable<Question> GetQuestionsByIsActive(bool isActive);
    IEnumerable<Question> GetQuestionsByAuthorQuiz(int q_id, int a_id);
    bool isDuplicate(string desc);
    bool isCorrectAnswer(int q_id, int a_id);
}