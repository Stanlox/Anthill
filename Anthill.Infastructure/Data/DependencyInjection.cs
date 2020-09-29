using Anthill.Infastructure.Interfaces;
using Anthill.Infastructure.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Anthill.Infastructure.Models;
using AutoMapper;
using Anthill.Infastructure.Mapping;
using Anthill.Infastructure.Services;
using Microsoft.AspNetCore.Identity;

namespace Anthill.Infastructure.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), 
                x => { x.EnableRetryOnFailure(); }));
            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<IProjectCategoryRepository, CategoryRepository>();
            services.AddTransient<IFavouriteRepository, FavouriresRepository>();
            services.AddTransient<ISearchProjectService, SearchService>();
            services.AddTransient<ServiceRepository>();
            services.AddTransient<IUserQuestion, UserQuestionsRepository>();

            var mapperConfig = new MapperConfiguration(x =>
            {
                x.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
