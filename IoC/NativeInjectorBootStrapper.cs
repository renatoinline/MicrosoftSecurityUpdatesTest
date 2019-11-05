using Data;
using Data.Repositories;
using Domain.Repositories.Interfaces;
using Domain.Services;
using Domain.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Add Service App 
            services.AddScoped<ISecurityUpdateService, SecurityUpdateService>();
            //services.AddScoped<ISubmissionService, SubmissionService>();

            //Add Repository
            services.AddScoped<ISecurityUpdateRepository, SecurityUpdateRepository>();
            //services.AddScoped<ISubmissionRepository, SubmissionRepository>();
        }
    }
}
