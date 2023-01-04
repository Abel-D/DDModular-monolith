
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddClientInfrastructureServices(this IServiceCollection services)
        {
            services.AddDbContext<ClientContext>(options => options.UseNpgsql("User ID=postgres;Password=Password;Server=localhost;Port=5432;Databasennk=Client;Pooling=true;"));
            services.AddScoped<IClientRepository, ClientRepository>();
            return services;
        }
    }
}
