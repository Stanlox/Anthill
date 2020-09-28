using Anthill.Infastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anthill.Infastructure.Interfaces
{
    public interface IFavouriteRepository
    {
        /// <summary>
        /// Delete project by id.
        /// </summary>
        /// <param name="id">Project id.</param>
        void DeleteProjectFromFavouritesAsync(int id);


        /// <summary>
        /// Add a project to favoutites.
        /// </summary>
        /// <param name="project">Input project.</param>
        void AddProjectToFavouritesAsync(Project project);

        /// <summary>
        /// Get all projects from favourites.
        /// </summary>
        List<Project> GetProjectFromFavourites();
    }
}
