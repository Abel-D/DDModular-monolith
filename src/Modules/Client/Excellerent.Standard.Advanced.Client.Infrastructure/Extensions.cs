using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Excellerent.Standard.Advanced.Client.Infrastructure
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
