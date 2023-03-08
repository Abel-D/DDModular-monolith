using Excellerent.Modular.Project.Core.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Excellerent.Modular.Project.Infrastructure
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
