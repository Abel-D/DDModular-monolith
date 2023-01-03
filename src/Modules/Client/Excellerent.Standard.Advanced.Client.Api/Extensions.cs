using Excellerent.Standard.Advanced.Client.Core;
using Excellerent.Standard.Advanced.Client.Infrastructure;
using Excellerent.Standard.Advanced.Client.Shared;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Api
{
    public static class Extensions
    {
        public static IServiceCollection AddClientModule(this IServiceCollection services)
        {
            services.AddClientCoreServices();
            services.AddClientInfrastructureServices();
            services.AddClientSharedServices();

            return services;
        }
        public static IApplicationBuilder UseClientModule(this IApplicationBuilder builder)
        {
            return builder;
        }
    }
}
