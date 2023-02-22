using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public static class Extensions
{
    public static IServiceCollection AddSharedApplicationServices(this IServiceCollection services)
    {
     // services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
      return services;
    }
    public static IApplicationBuilder UseSharedInfrastructureModule(this IApplicationBuilder builder)
    {
        return builder;
    }
}