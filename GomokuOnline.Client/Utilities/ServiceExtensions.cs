using GomokuOnline.Client.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GomokuOnline.Client.Utilities;

/// <summary>
/// Contains extension methods related to registering services.
/// </summary>
public static class ServiceExtensions
{
    /// <summary>
    /// Adds common services that are needed by both the server and client projects to avoid code duplication.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to register the services to.</param>
    /// <returns><paramref name="services"/></returns>
    public static IServiceCollection AddSharedServices(this IServiceCollection services) => services.AddScoped<IJsConsole, JsConsole>();
}
