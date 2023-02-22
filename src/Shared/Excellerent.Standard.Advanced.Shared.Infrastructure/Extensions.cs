using Excellerent.Standard.Advanced.Shared.Infrastructure.Contracts.Command;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Contracts.Repository;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Excellerent.Standard.Advanced.Shared.Infrastructure;
public static class Extensions
{
    public static IServiceCollection AddSharedInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IAsyncRepository<>), typeof(AsyncRepository<>));
       
        return services;
    }

}
