using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace Repo.Interfaces;

interface IRepository<T> where T:class{

    //retrival
    T Get(int id);

    IEnumerable<T> All();
    IEnumerable<T> Find (Expression<Func<T, bool>> exp);

    //adding
    void Add(ref T enity);
    void AddRange(IEnumerable<T> entities);

    //Removal
    void Remove(T entity);

    void RemoRange(IEnumerable<T> entities);


}