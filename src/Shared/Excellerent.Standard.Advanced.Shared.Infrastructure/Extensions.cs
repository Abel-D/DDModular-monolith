using Excellerent.Standard.Advanced.Shared.Application.Contracts.Repository;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Database;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Excellerent.Standard.Advanced.Shared.Infrastructure;
public static class Extensions
{
    public static IServiceCollection AddSharedInfrastructureServices(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<BaseContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped(typeof(IAsyncRepository<>), typeof(AsyncRepository<>));

        return services;
    }

}
