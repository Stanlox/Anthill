using System;
using System.Collections.Generic;
using System.Text;

namespace Anthill.Infastructure.Interfaces
{
    public interface ISearchProjectService
    {
        IEnumerable<string> GetMostSimilarProjectsName(string nameProject);
    }
}
