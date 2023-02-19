using Repo.Interfaces;
using Repo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Storage;

public class UnitOfWork: IUnitOfWork 
{
   
    public  QuizDB _context{get;set;}
    private IDbContextTransaction _objTran;
    public UnitOfWork(QuizDB _db){
        _context=_db;
    }

    public void Commit()
    {
       _objTran.Commit();
    }

    public void CreateTransaction()
    {
        _objTran=_context.Database.BeginTransaction();
    }

    public void Rollback()
    {
      _objTran.Rollback();
    }

    public void Save()
    {
        _context.SaveChanges();
    }

}