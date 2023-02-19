using Repo.Models;
using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;
namespace Repo.Models {

    public class UserIdentiy:IdentityUser{
        [Required]
        public int UserId{get;set;}
    }

}