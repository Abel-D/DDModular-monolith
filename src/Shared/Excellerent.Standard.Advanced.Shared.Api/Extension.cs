using Excellerent.Standard.Advanced.Shared.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public static class Extensions
{
    public static IServiceCollection AddSharedModule(this IServiceCollection services)
    {
        services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
        services.AddSharedInfrastructureServices();
        services.AddSharedApplicationServices();
        return services;
    }
    public static IApplicationBuilder UseSharedApiModule(this IApplicationBuilder builder)
    {
        return builder;
    }
}