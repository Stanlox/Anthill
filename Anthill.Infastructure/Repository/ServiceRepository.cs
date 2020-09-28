using Anthill.Infastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anthill.Infastructure.Repository
{
    public class ServiceRepository
    {
        public ISearchProjectService Search { get; }

        public ServiceRepository(ISearchProjectService search)
        {
            this.Search = search;
        }
    }
}
