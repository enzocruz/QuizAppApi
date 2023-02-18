
using System;
using Repo.Imp;
using Repo.Models;
public class Program {
  
    // Main Method
    static public void Main(String[] args)
    {
        
        UnitOfWork<QuizDB> unitOfWork=new UnitOfWork<QuizDB>();
        Repository<Quiz> repository=new Repository<Quiz>(unitOfWork.Context);
        repository.Add(new Quiz(){
                Title="Test",Description="None"
        
                ,CreatedTime=DateTime.Now
        });
        unitOfWork.Save();
        var l=repository.All();
        Console.WriteLine("Output");
        foreach(var s in l ){
            Console.WriteLine(s.Title);
        }
    }
}