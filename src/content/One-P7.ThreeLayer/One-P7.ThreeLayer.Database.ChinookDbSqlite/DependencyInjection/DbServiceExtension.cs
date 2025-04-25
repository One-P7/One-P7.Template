using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ThreeLayer.Database.ChinookDbSqlite.DependencyInjection;

public static class DbServiceExtension
{
    /// <summary>
    /// 註冊 Adventure Works 的 EFCore DbContext
    /// </summary>
    /// <returns></returns>
    public static IServiceCollection AddChinookSqliteDbContext(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // 註冊 EF Core Db Context
        services.AddDbContext<ChinookSqliteContext>(
            (provider, builder) =>
            {
                var loggerFactory = provider.GetRequiredService<ILoggerFactory>();

                builder.UseLoggerFactory(loggerFactory)
                       .UseSqlite(configuration.GetConnectionString("ChinookSqliteConnection"));
            },
            ServiceLifetime.Scoped,
            ServiceLifetime.Singleton);

        return services;
    }
}