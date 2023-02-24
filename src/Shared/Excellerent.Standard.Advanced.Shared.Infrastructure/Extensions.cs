using Excellerent.Standard.Advanced.Shared.Application.Contracts.Repository;

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
