
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Contracts.Command;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Excellerent.Standard.Advanced.Client.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddClientInfrastructureServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ClientContext>(options=> 
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IClientRepository, ClientRepository>();
            
            return services;
        }
    }
}
