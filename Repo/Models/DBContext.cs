using System.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

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
             modelBuilder.Entity<User>().HasData(new User(){
                Id=1
                ,FirstName="Admin"
                ,LastName="Admin"
                //,CreatedDate=DateTime.Now
            });
             modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole {Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Administrator", NormalizedName = "ADMINISTRATOR".ToUpper() }
                ,new IdentityRole {Id = "25ab6d7e-585f-469e-902b-f60008bdfb03", Name = "Student", NormalizedName = "Student".ToUpper()} 
                ,new IdentityRole {Id = "9911b550-e25d-4889-8d72-df82d884e7b7", Name = "Teacher", NormalizedName = "Teacher".ToUpper()} );


            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<UserIdentiy>();

           
            //Seeding the User to AspNetUsers table
           modelBuilder.Entity<UserIdentiy>().HasData(
                new UserIdentiy
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    PasswordHash = hasher.HashPassword(null, "p@$$W0rd")
                    ,UserId=1
                }
            );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210", 
                UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
            }
            );

            
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