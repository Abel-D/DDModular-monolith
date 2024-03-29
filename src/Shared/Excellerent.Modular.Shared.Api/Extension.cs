﻿using Excellerent.Modular.Shared.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class Extensions
{
    public static IServiceCollection AddSharedModule(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSharedApplicationServices();
        services.AddSharedInfrastructureServices(configuration);
        return services;
    }
    public static IApplicationBuilder UseSharedApiModule(this IApplicationBuilder builder)
    {
        return builder;
    }
}