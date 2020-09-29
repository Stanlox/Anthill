using Anthill.Infastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anthill.Infastructure.Interfaces
{
    public interface IUserQuestion
    {
        /// <summary>
        /// Get all questions.
        /// </summary>
        /// <returns>Collection of the UserQuestion</returns>
        IQueryable<UserQuestion> Get();

        /// <summary>
        /// Delete questios by id.
        /// </summary>
        void Delete(int id);

        /// <summary>
        /// Add new question.
        /// </summary>
        void Add(UserQuestion userQuestion);
    }
}
