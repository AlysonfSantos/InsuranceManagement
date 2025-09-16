using Microsoft.Extensions.DependencyInjection;
using Shared.Library.MediatR.Behaviors;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Shared.Library.MediatR;

[ExcludeFromCodeCoverage]
public static class ConfigureMediatR
{
    public static IServiceCollection RegisterMediatR(this IServiceCollection services, params Assembly[] assemblies)
    {
        services.AddMediatR(config =>
        {
            config.AddOpenBehavior(typeof(UnhandledExceptionBehavior<,>));
            config.AddOpenBehavior(typeof(PerformanceBehavior<,>));
            config.AddOpenRequestPreProcessor(typeof(LoggingBehavior<>));
            config.RegisterServicesFromAssemblies(assemblies);
        });

        return services;
    }
}
