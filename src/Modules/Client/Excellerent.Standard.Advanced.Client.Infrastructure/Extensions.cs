
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Contracts.Command;
using Microsoft.Extensions.DependencyInjection;

namespace Excellerent.Standard.Advanced.Client.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddClientInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ClientContext>();
            services.AddScoped<IClientRepository, ClientRepository>();

            return services;
        }
    }
}
