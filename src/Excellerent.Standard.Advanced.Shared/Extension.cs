
using Excellerent.Standard.Advanced.Shared.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

public static class SharedExtension
{
    public static IServiceCollection AddSharedServices(IServiceCollection services, IConfiguration configration)

    {
        services.AddDbContext<BaseContext>(options => options.UseNpgsql("User ID=postgres;Password=Password;Server=localhost;Port=5432;Database=epp;Pooling=true;"));

        return services;
    }
}