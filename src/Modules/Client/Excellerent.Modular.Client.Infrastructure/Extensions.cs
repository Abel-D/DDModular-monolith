using Excellerent.Modular.Client.Core.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Excellerent.Modular.Client.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddClientInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IClientRepository, ClientRepository>();

            return services;
        }
    }
}
