using Anthill.Infastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anthill.Infastructure.Interfaces
{
    public interface IProjectCategoryRepository
    {
        IQueryable<CategoryProjects> allСategories { get; }
    }
}
