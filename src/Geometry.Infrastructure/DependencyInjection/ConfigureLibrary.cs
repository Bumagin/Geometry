using Geometry.Abstractions.Interfaces;
using Geometry.Application;
using Microsoft.Extensions.DependencyInjection;

namespace Geometry.Infrastructure.DependencyInjection;

public static class ConfigureLibrary
{
    public static void AddGeometryLibrary(this IServiceCollection services)
    {
        services.AddScoped<IFigureManager, FigureManager>();
    }
}