using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anthill.API.Interfaces;
using Anthill.Infastructure.Entities;
using Anthill.Infastructure.Interfaces;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anthill.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IEmailService emailService;
        private readonly IUnitOfWork unitOfWork;
        public QuestionController(IEmailService emailService, IUnitOfWork unitOfWork)
        {
            this.emailService = emailService;
            this.unitOfWork = unitOfWork;
        }

        [HttpPost("[action]")]
        public IActionResult Add([FromBody] UserQuestion question)
        {
            if (ModelState.IsValid)
            {
                this.unitOfWork.UserQuestion.Add(question);
                this.emailService.SendEmail(question.Email, "Обратная связь", "Спасибо за ваш вопрос. С вами обязательно свяжутся наши администраторы!!");
            }
            else
            {
                return StatusCode(400);
            }
            return Ok();
        } 

        [HttpDelete("[action]")]
        public IActionResult Delete(int id)
        {
            this.unitOfWork.UserQuestion.Delete(id);
            return Ok();
        }


        [HttpGet("[action]")]
        public IActionResult Get()
        {
            return Ok(this.unitOfWork.UserQuestion.Get());
        }
    }
}
