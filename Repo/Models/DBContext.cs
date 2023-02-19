using System.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Repo.Models{
    public class QuizDB : IdentityDbContext<UserIdentiy>
    {
        private string ConString="Server=127.0.0.1;Port=6033;Uid=root;Pwd=password;Database=QuizDB ";
        
         public QuizDB (DbContextOptions<QuizDB> options)
            : base(options)
        {
                
        }
        public QuizDB(){

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           //optionsBuilder.UseMySql(ConString,ServerVersion.AutoDetect(ConString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserIdentiy>().ToTable("Accounts");
            
        }
        //entities

        public DbSet<Quiz> Quizzes{get;set;}
        public DbSet<User> Users{get;set;}
    
    } 
}