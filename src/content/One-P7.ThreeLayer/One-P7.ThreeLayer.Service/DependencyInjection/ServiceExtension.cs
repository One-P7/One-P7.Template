using Microsoft.Extensions.DependencyInjection;
using ThreeLayer.Service.Implements;
using ThreeLayer.Service.Interfaces;

namespace ThreeLayer.Service.DependencyInjection;

/// <summary>
/// Service 擴充
/// </summary>
public static class ServiceExtension
{
    /// <summary>
    /// 註冊 Service
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddService(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<IArtistService, ArtistService>();
        services.AddScoped<IAlbumService, AlbumService>();
        return services;
    }
}