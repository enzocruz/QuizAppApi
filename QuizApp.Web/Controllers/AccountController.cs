using Microsoft.AspNetCore.Mvc;
using Repo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using QuizApp.Web.Models.ViewModels;
using QuizApp.Web.Models;
using Repo.Imp;
using System.Text;

namespace QuizApp.Web.Controllers{

    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {

        private readonly IConfiguration _configuration;

        private readonly QuizDB _db;
        private readonly UserManager<UserIdentiy> _userManager;
        private readonly SignInManager<UserIdentiy> _signInManager;
        private readonly UnitOfWork unitOfWork;
        private readonly Repository<User> userRepo;
        public AccountController(QuizDB db,UserManager<UserIdentiy>_userManager
        ,SignInManager<UserIdentiy> _signInManager
        ,  IConfiguration _configuration)

        {
            
            _db=db;
            this._userManager=_userManager;
            this._signInManager=_signInManager;
            this.unitOfWork=new UnitOfWork(_db);
            this.userRepo=new Repository<User>(unitOfWork._context);
            this._configuration=_configuration;
        }

        [HttpPost]
        [Route("Register")]
       public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
        {
            var userExists = await _userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });
            unitOfWork.CreateTransaction();
            var u=new User(){
                FirstName=model.FirstName
                ,LastName=model.LastName
                
            };
            userRepo.Add(ref u);
            unitOfWork.Save();
            UserIdentiy user = new()
            {
                Email = model.Email,
                //SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
                ,UserId=u.Id
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded){
                unitOfWork.Rollback();
                 return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });
            }
               
            unitOfWork.Commit();
            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }
         [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

               var token = GetToken(authClaims);

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return Unauthorized();
        }

        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }
    }
    
}