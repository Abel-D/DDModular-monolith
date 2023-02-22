using Excellerent.Standard.Advanced.Client.Core.Commands.AddClient;
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Contracts.Command;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

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
