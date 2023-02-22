using Excellerent.Standard.Advanced.Shared.Infrastructure;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Contracts.Command;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Contracts.Query;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

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