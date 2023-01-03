using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Shared
{
    public static class Extensions
    {
        public static IServiceCollection AddClientSharedServices(this IServiceCollection services)
        {
            return services;
        }
    }
}
