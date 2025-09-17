using MassTransit;
using Shared.Library.Bus.Exceptions;

namespace Shared.Library.Bus.Services;

public interface IMessagingService
{
    /// <summary>
    /// Publish a message.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task PublishMessageAsync<T>(T message, CancellationToken cancellationToken);
}

public class MessagingService(IBus bus) : IMessagingService
{
    private readonly IBus _bus = bus;

    /// <inheritdoc/>
    public async Task PublishMessageAsync<T>(T message, CancellationToken cancellationToken)
    {
        if (object.Equals(message, null))
            throw new InvalidMessageException(nameof(message));

        await _bus.Publish(message, cancellationToken);
    }
}