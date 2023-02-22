using Excellerent.Standard.Advanced.Client.Core;
using Excellerent.Standard.Advanced.Client.Infrastructure;
using Excellerent.Standard.Advanced.Client.Shared;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Excellerent.Standard.Advanced.Client.Api
{
    public static class Extensions
    {
        public static IServiceCollection AddClientModule(this IServiceCollection services)
        {

            services.AddClientInfrastructureServices();
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
