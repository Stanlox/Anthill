using Anthill.Infastructure.Data;
using Anthill.Infastructure.Interfaces;
using Anthill.Infastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anthill.Infastructure.Repository
{
    public class FavouriresRepository : IFavouriteRepository
    {
        private readonly ApplicationDbContext dbContent;
        public FavouriresRepository(ApplicationDbContext dbContent)
        {
            this.dbContent = dbContent;
        }
        public async void AddProjectToFavouritesAsync(Project project)
        {
            if(!this.dbContent.Favourites.Any(x => x.Projects.Id == project.Id))
            {
                this.dbContent.Favourites.Add(new Favourites
                {
                    Projects = project
                });
            }

            await dbContent.SaveChangesAsync();
        }

        public async void DeleteProjectFromFavouritesAsync(int id)
        {
            var project = await dbContent.Favourites.SingleAsync(x => x.id == id);

            if (project != null)
            {
                this.dbContent.Favourites.Remove(project);
                await dbContent.SaveChangesAsync();
            }
        }

        public List<Project> GetProjectFromFavourites()
        {
             return (List<Project>)this.dbContent.Favourites.Include(x => x.Projects);        
        }
    }
}
