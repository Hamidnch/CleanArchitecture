using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain;
using CleanArchitecture.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
