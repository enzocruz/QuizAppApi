using Microsoft.AspNetCore.Mvc;
using Repo.Models;
using Microsoft.AspNetCore.Authorization;
using Repo.Imp;
using QuizApp.Web.Models;

namespace QuizApp.Web.Controllers{
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

        [HttpGet(Name = "Questions")]
        public IEnumerable<QuestionViewModel> Get()
        {
            Repository<Question> repo=new Repository<Question>(_db);
            List<QuestionViewModel> questions;
             questions = repo.All().Select(x => new QuestionViewModel
            {
                QuizId = x.Quiz.Id,
                QuestionDescription = x.QuestionDesc,
                AuthorId = x.Quiz.User.Id,
                QuestionType = x.QuestionType.Id

            }).ToList();
            return questions;
        }
    }
}