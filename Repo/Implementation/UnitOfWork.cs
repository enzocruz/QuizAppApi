using Repo.Interfaces;
using Repo.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;

namespace Repo.Imp;

public class UnitOfWork<TContext>: IUnitOfWork<TContext> where TContext : DbContext ,new ()
{
    private readonly TContext _context;
    public TContext Context {get{return _context;}}

    public UnitOfWork(){
        _context=new TContext();
    }

    public void Commit()
    {
        throw new NotImplementedException();
    }

    public void CreateTransaction()
    {
        throw new NotImplementedException();
    }

    public void Rollback()
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}