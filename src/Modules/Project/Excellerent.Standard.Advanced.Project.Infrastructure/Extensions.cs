using Excellerent.Standard.Advanced.Project.Core.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Excellerent.Standard.Advanced.Project.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddProjectInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddDbContext<ProjectContext>(options => options.UseNpgsql("User ID=postgres;Password=Password;Server=localhost;Port=5432;Database=Project;Pooling=true;"));

            return services;
        }
    }
}
