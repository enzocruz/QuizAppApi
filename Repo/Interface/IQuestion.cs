using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace Repo.Interfaces;

public interface IQuestion : IRepository<Question>
{
    IEnumerable<Question> GetQuestionsByAuthor(int a_id);
    IEnumerable<Question> GetQuestionsByDateCreated(DateTime dateTime);
    IEnumerable<Question> GetQuestionsByIsActive(bool isActive);
    bool isDuplicate(string desc);
}