using Microsoft.Extensions.DependencyInjection;
using ThreeLayer.Repository.Implements;
using ThreeLayer.Repository.Interfaces;

namespace ThreeLayer.Repository.DependencyInjection;

/// <summary>
/// Repository 擴充
/// </summary>
public static class RepositoryExtension
{
    /// <summary>
    /// 註冊 Repository
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        return services;
    }
}