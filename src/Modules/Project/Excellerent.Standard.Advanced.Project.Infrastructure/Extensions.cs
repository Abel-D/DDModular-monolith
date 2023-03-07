using Excellerent.Standard.Advanced.Project.Core.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Excellerent.Standard.Advanced.Project.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddProjectInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IProjectRepository, ProjectRepository>();
            return services;
        }
    }
}
