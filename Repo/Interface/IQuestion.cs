using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace Repo.Interfaces;

public interface IQuestion : IRepository<Quiz>
{
    IEnumerable<Quiz> GetQuestionsByAuthor(int a_id);
    IEnumerable<Quiz> GetQuestionsByDateCreated(DateTime dateTime);
    IEnumerable<Quiz> GetQuestionsByIsActive(bool isActive);
}