using Microsoft.AspNetCore.Mvc;
using QuizApp.Web.Models;
using Repo.Implementation;
using Repo.Models;

namespace QuizApp.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuizController : ControllerBase
    {
        private readonly QuizDB _db;
        private readonly UnitOfWork unitOfWork;
        private readonly QuizRepository quizRepository;

        public QuizController(QuizDB db)
        {
            _db = db;
            this.unitOfWork = new UnitOfWork(_db);
            this.quizRepository = new QuizRepository(unitOfWork._context);
            _db = db;
        }

        [HttpGet("Quizzes")]
        public IEnumerable<QuizViewModel> Get()
        {
            List<QuizViewModel> quiz;
            quiz = quizRepository.All().Select(x => new QuizViewModel
            {
                AuthorId = x.UserId,
                QuizId = x.Id,
                Title = x.Title
            }).ToList();
            return quiz;
        }
        [HttpGet("QuizzesByAuthor/{a_id}")]
        public IEnumerable<QuizViewModel> GetQuizzesByAuthor(int a_id)
        {
            List<QuizViewModel> quiz;
            quiz = quizRepository.GetQuizByAuthor(a_id).Select(x => new QuizViewModel
            {
                AuthorId=x.UserId,
                QuizId=x.Id,
                Title = x.Title,
                DateCreated =x.CreatedTime
            }).ToList();
            return quiz;
        }

    }
}
