﻿using Excellerent.Modular.Client.Core.Commands.AddClient;
using Excellerent.Modular.Project.Core;
using Excellerent.Modular.Project.Core.Commands.Add_Project;
using Excellerent.Modular.Project.Core.Queries.GetProjects;
using Excellerent.Modular.Project.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Modular.Project.Api
{
    public static class Extensions
    {
        public static IServiceCollection AddProjectModule(this IServiceCollection services)
        {
            //services.AddMediatR(typeof(AddProjectCommand).GetTypeInfo().Assembly,
            //    typeof(AddClientCommandHandler).GetTypeInfo().Assembly,
            //    typeof(GetProjectsQuery).Assembly,
            //    typeof(GetProjectsQueryHandler).GetTypeInfo().Assembly); ;

            services.AddProjectCoreServices();
            services.AddProjectInfrastructureServices();
            return services;
        }
        public static IApplicationBuilder UseProjectModule(this IApplicationBuilder builder)
        {
            return builder;
        }
    }
}
