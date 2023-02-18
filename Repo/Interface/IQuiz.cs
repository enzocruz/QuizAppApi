using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace Repo.Interfaces;

interface IQuiz<T> where T:class{

    IEnumerable<T>GetTopScore();
   


}