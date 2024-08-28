using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ThreeLayer.Database.AdventureWorks.DependencyInjection;

public static class DbServiceExtension
{
    /// <summary>
    /// 註冊 Adventure Works 的 EFCore DbContext
    /// </summary>
    /// <returns></returns>
    public static IServiceCollection AddAdventureWorksDbContext(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // 註冊 EF Core Db Context
        services.AddDbContext<AdventureWorksContext>(
            (provider, builder) =>
            {
                var loggerFactory = provider.GetRequiredService<ILoggerFactory>();

                builder.UseLoggerFactory(loggerFactory)
                       .UseSqlServer(configuration.GetConnectionString("AdventureWorksConnection"),
                                     x => x.UseHierarchyId())
                       .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            },
            ServiceLifetime.Scoped,
            ServiceLifetime.Singleton);

        return services;
    }
}