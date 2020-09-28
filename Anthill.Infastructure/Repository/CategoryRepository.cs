using Anthill.Infastructure.Data;
using Anthill.Infastructure.Interfaces;
using Anthill.Infastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anthill.Infastructure.Repository
{
    public class CategoryRepository : IProjectCategoryRepository
    {
        private readonly ApplicationDbContext dbContent;

        public CategoryRepository(ApplicationDbContext dbContent)
        {
            this.dbContent = dbContent;
        }

        public IQueryable<CategoryProjects> allСategories
        {
            get
            {
                return dbContent.Categories;
            }
        }
    }
}
