using Anthill.Infastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anthill.Infastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IProjectCategoryRepository CategoryProjects { get; }
        public IProjectRepository Projects { get; }
        public IFavouriteRepository Favourites { get; }
    }
}
