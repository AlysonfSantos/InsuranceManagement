namespace Shared.Library.Bus.Configuration;

public sealed class BusConfiguration
{
    /// <summary>
    /// RabbitMQ host.
    /// </summary>
    public string Host { get; set; } = string.Empty;

    /// <summary>
    /// <summary>
    /// RabbitMQ user name.
    /// </summary>
    public string UserName { get; set; } = string.Empty;

    /// <summary>
    /// RabbitMQ password.
    /// </summary>
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// The retry interval configuration.
    /// </summary>
    public RetryConfiguration RetryConfiguration { get; init; } = new();
}
