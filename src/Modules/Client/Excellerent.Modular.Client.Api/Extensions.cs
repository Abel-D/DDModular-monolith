using Excellerent.Modular.Client.Core;
using Excellerent.Modular.Client.Infrastructure;
using Excellerent.Modular.Client.Shared;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Excellerent.Modular.Client.Api
{
    public static class Extensions
    {
        public static IServiceCollection AddClientModule(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddClientInfrastructureServices(configuration);
            services.AddClientCoreServices();
            services.AddClientSharedServices();

            return services;
        }
        public static IApplicationBuilder UseClientModule(this IApplicationBuilder builder)
        {
            return builder;
        }
    }
}
