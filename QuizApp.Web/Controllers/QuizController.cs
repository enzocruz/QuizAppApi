using Microsoft.AspNetCore.Mvc;
using Repo.Models;
using Microsoft.AspNetCore.Authorization;
using Repo.Imp;
namespace QuizApp.Web.Controllers{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class QuizController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly QuizDB _db;
        public QuizController(ILogger<WeatherForecastController> logger,QuizDB db)
        {
            _logger = logger;
            _db=db;
        }

        [HttpGet(Name = "Quizes")]
        public IEnumerable<Quiz> Get()
        {
            Repository<Quiz> repo=new Repository<Quiz>(_db);
            return repo.All();
        }
    }
}