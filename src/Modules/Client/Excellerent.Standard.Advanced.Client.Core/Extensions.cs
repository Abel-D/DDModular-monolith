using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddClientCoreServices(this IServiceCollection services)
        {
            services.AddTransient<IClientService, ClientService>();
            return services;
        }
    }
}
