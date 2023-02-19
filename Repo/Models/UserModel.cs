
using System.ComponentModel.DataAnnotations;
namespace Repo.Models{
    public class User{
        [Required]
        public int Id{get;set;}
        [Required]
        public string FirstName{get;set;}

        [Required]
        public string LastName{get;set;}

        public string? MiddleName{get;set;}

        [Timestamp]
        DateTime CreatedDate{get;set;}=DateTime.Now;

        public UserIdentiy Accounts{get;set;}
    }
}