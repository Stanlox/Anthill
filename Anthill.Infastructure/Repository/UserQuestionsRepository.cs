using Anthill.Infastructure.Data;
using Anthill.Infastructure.Entities;
using Anthill.Infastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anthill.Infastructure.Repository
{
    public class UserQuestionsRepository : IUserQuestion
    {
        private ApplicationDbContext dbContext;
        public UserQuestionsRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Delete(int id)
        {
            var userQuestion = this.dbContext.UserQuestions.Find(id);
            if(userQuestion != null)
            {
                this.dbContext.UserQuestions.Remove(userQuestion);
            }

            this.dbContext.SaveChanges();
        }

        public IQueryable<UserQuestion> Get()
        {
            return this.dbContext.UserQuestions;
        }

        public void Add(UserQuestion userQuestion)
        {
            this.dbContext.Add(userQuestion);
            this.dbContext.SaveChanges();
        }
    }
}
