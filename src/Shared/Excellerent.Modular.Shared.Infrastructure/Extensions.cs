using Excellerent.Modular.Shared.Application.Contracts.Repository;
using Excellerent.Modular.Shared.Infrastructure.Database;
using Excellerent.Modular.Shared.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Excellerent.Modular.Shared.Infrastructure;
public static class Extensions
{
    public static IServiceCollection AddSharedInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BaseContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped(typeof(IAsyncRepository<>), typeof(AsyncRepository<>));

        return services;
    }

}
