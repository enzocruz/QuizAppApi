using Microsoft.AspNetCore.Mvc;
using Repo.Models;
using Microsoft.AspNetCore.Authorization;
using Repo.Imp;
using QuizApp.Web.Models;
using Repo.Implementation;

namespace QuizApp.Web.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : ControllerBase
    {
        private readonly QuizDB _db;
        private readonly UnitOfWork unitOfWork;
        private readonly QuestionRepository questionsRepo;
        private readonly QuestionOptionReposity optionReposity;
        
        public QuestionController(QuizDB db)
        {
            _db = db;
            this.unitOfWork = new UnitOfWork(_db);
            this.questionsRepo = new QuestionRepository(unitOfWork._context);
            _db = db;
        }

        [HttpGet("Questions")]
        public IEnumerable<QuestionViewModel> Get()
        {           
            List<QuestionViewModel> questions;
             questions = questionsRepo.All().Select(x => new QuestionViewModel
            {
                QuizId = x.QuizId,
                QuestionDescription = x.QuestionDesc,
                AuthorId = x.UserId,
                QuestionType = x.QuestionTypeId,
                IsActive = x.IsActive
                

            }).ToList();
            return questions;
        }
        [HttpPost]
        [Route("CreateQuestion")]
        public async Task<IActionResult> CreateQuestion([FromBody] QuestionViewModel model)
        {
            var checkifExists = questionsRepo.isDuplicate(model.QuestionDescription);
            if (checkifExists == true)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Question exists!" });
            unitOfWork.CreateTransaction();
            var q = new Question
            {
                QuestionDesc = model.QuestionDescription,
                QuestionTypeId = model.QuestionType,
                QuizId = model.QuizId,
                IsActive = model.IsActive,
                UserId = model.AuthorId
            };
            questionsRepo.Add(ref q);
            unitOfWork.Save();
            unitOfWork.Commit();
            return Ok(new Response { Status = "Success", Message = "Question created successfully!" });

        }
        [HttpPost]
        [Route("CheckAnswer")]
        public async Task<bool> CheckAnswer([FromBody] AnswerViewModel model)
        {
            bool isCorrect = questionsRepo.isCorrectAnswer(model.Q_id, model.Q_id);
            return isCorrect;
        }
        [HttpGet("GetQuestionByQuiz/{q_id}/{a_id}")]
        public IEnumerable<QuestionViewModel> GetQuestionByQuiz(int q_id, int a_id)
        {
            List<QuestionViewModel> questions;
            questions = questionsRepo.GetQuestionsByAuthorQuiz(q_id,a_id).Select(x => new QuestionViewModel
            {
                QuizId = x.QuizId,
                QuestionDescription = x.QuestionDesc,
                AuthorId = x.UserId,
                QuestionType = x.QuestionTypeId,
                IsActive = x.IsActive
            }).ToList();
            return questions;
        }
        [HttpGet("GetQuestionOptions/{qid}")]
        public IEnumerable<QuesstionOptionsViewModel> GetOptionsByQuestion(int qid)
        {
            List<QuesstionOptionsViewModel> qoptions;
            qoptions = optionReposity.GetOptionsByQuestion(qid).Select(x => new QuesstionOptionsViewModel
            {
                QuestionId = x.QuestionId,
                QuestionsOptions = x.QuestionOpt
            }).ToList();
            return qoptions;
        }
    }
}