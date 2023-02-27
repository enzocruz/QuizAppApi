using System.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Repo.Models{
    public class QuizDB : IdentityDbContext<UserIdentiy>
    {
        private string ConString="Server=127.0.0.1;Port=3306;Uid=root;Pwd=;Database=QuizDB";
        
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
        public DbSet<User> Users { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get;set;}
        public DbSet<UserQuestionAnswer> UserQuestionAnswers { get;set;}
        public DbSet<Question> Questions { get;set;}
        public DbSet<QuestionType> QuestionTypes { get;set;}
        public DbSet<UserScore> userScores { get;set;}
    
    } 
}