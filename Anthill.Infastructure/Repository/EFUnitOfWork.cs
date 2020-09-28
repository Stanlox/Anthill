using Anthill.Infastructure.Data;
using Anthill.Infastructure.Interfaces;
using Anthill.Infastructure.Services;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Anthill.Infastructure.Repository
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        private ApplicationDbContext dbContext;
        public IProjectRepository Projects { get; }
        public IProjectCategoryRepository CategoryProjects { get; }
        public IFavouriteRepository Favourites { get; }
        public ISearchProjectService Search { get; }

        public EFUnitOfWork(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            Projects = new ProjectRepository(dbContext);
            CategoryProjects = new CategoryRepository(dbContext);
            Favourites = new FavouriresRepository(dbContext);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.dbContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
