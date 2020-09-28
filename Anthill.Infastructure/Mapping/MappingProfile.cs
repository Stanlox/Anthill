using Anthill.Infastructure.DTO;
using Anthill.Infastructure.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Anthill.Infastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Project, ProjectsByCategoryDTO>()
                .ForMember(c => c.CategoryName, x => x.MapFrom(m => m.Category.CategoryName));

            CreateMap<Project, CompletedProjectsDTO>();
        }
    }
}
