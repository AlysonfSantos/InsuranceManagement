using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Shared.Library.Bus.Configuration;
using Shared.Library.Bus.Services;

namespace Shared.Library.Bus;

public static class ConfigureBusServices
{
    public static IServiceCollection AddBusConfiguration(this IServiceCollection services,
        BusConfiguration busConfiguration,
        Action<IBusRegistrationConfigurator> configure)
    {
        services.AddTransient<IMessagingService, MessagingService>();

        services.AddMassTransit(x =>
        {
            x.AddDelayedMessageScheduler();

            //Call the action passed in 
            configure(x);

            ConfigureUsingRabbitMq(x, busConfiguration);

            x.AddInMemoryInboxOutbox();
        });

        return services;
    }

    private static void ConfigureUsingRabbitMq(IBusRegistrationConfigurator configurator,
       BusConfiguration configuration)
    {
        configurator.UsingRabbitMq((context, cfg) =>
        {
            cfg.Host(configuration.Host, h =>
            {
                h.Username(configuration.UserName);
                h.Password(configuration.Password);
            });

            cfg.UseDelayedRedelivery(r => r.Intervals(configuration.RetryConfiguration.DelayedRedeliveryIntervals));
            cfg.UseMessageRetry(r => r.Immediate(configuration.RetryConfiguration.ImmediateRetries));

            cfg.ConfigureEndpoints(context);

            cfg.AutoStart = true;
        });
    }
}
