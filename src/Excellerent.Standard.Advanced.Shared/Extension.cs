using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

public static class Extensions
{
    public static IServiceCollection AddSharedServices(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        return services;
    }
    public static IApplicationBuilder UseSharedModule(this IApplicationBuilder builder)
    {
        return builder;
    }
}