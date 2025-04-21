using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace One_P7.ThreeLayer.Database.SQLiteAdventureWorks.DependencyInjection;

public static class SQLiteDbServiceExtension
{
    /// <summary>
    /// 註冊 Adventure Works 的 EFCore DbContext
    /// </summary>
    /// <returns></returns>
    public static void AddSQLiteDbContext(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // 註冊 EF Core Db Context
        services.AddDbContext<AdventureWorksSqliteDbContext>(
            (provider, builder) =>
            {
                var loggerFactory = provider.GetRequiredService<ILoggerFactory>();

                builder.UseLoggerFactory(loggerFactory)
                       .UseSqlite(configuration.GetConnectionString("AdventureWorksSQLiteConnection"));
            },
            ServiceLifetime.Scoped,
            ServiceLifetime.Singleton);
    }
}
