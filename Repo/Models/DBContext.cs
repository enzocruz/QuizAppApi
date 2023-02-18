
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Repo.Models{
    public class QuizDB : DbContext
    {
        private string ConString="Server=127.0.0.1;Port=6033;Uid=root;Pwd=password;Database=QuizDB ";
        
        public QuizDB()
        {
    
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConString,ServerVersion.AutoDetect(ConString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities

        public DbSet<Quiz> Quizzes{get;set;}
    
    } 
}