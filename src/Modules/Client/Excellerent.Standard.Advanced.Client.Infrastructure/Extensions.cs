
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Excellerent.Standard.Advanced.Client.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddClientInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IClientRepository,ClientRepository>();
            return services;
        }
    }
}
