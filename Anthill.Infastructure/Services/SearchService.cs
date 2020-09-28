using Anthill.Infastructure.Interfaces;
using Anthill.Infastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anthill.Infastructure.Services
{
    public class SearchService : ISearchProjectService
    {
        private List<string> listOfProjectsName = new List<string>();
        public SearchService(IUnitOfWork unitOfWork)
        {
            foreach (var proj in unitOfWork.Projects.projects)
            {
                listOfProjectsName.Add(proj.Name);
            }
        }
        public IEnumerable<string> GetMostSimilarProjectsName(string nameProject)
        {

            var requestCommandSymbols = nameProject.ToUpperInvariant();
            var projectIntersactions = listOfProjectsName.Select(command => (command, command.ToUpperInvariant()))
                .Select(commandTuple => (commandTuple.command, commandTuple.Item2.Intersect(requestCommandSymbols).Count()));
            var max = projectIntersactions.Max(tuple => tuple.Item2);
            return max > 2 ? projectIntersactions.Where(tuple => tuple.Item2.Equals(max)).Select(tuple => tuple.command) : Enumerable.Empty<string>();
        }
    }
}
