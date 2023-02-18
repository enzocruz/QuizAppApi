using Repo.Interfaces;
using System.Collections.Generic;
using System;

using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Repo.Imp{

public class Repository<T> : IRepository<T> where T : class
{

    protected readonly DbContext _context;
    public Repository(DbContext context){
        _context=context;
    }
   

    public void Add(T enity)
    {
       _context.Set<T>().Add(enity);
    }

    public void AddRange(IEnumerable<T> entities)
    {
       _context.Set<T>().AddRange(entities);
    }

    public IEnumerable<T> All()
    {
        return _context.Set<T>().ToList();
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> exp)
    {
         return _context.Set<T>().Where(exp);
    }

    public T Get(int id)
    {
         return _context.Set<T>().Find(id);
    }

    public void RemoRange(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
    }

    public void Remove(T entity)
    {
        _context.Set<T>().Add(entity);
    }
}
}


