using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Shared.Library.MediatR.Behaviors;

public class PerformanceBehavior<TRequest, TResponse>(ILogger<TRequest> logger) : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly ILogger _logger = logger;
    private readonly Stopwatch _timer = new();
    private const ushort REQUEST_TIME_THRESHOLD = 500;

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        _timer.Start();
        var response = await next();
        _timer.Stop();

        var elapsedMilliseconds = _timer.ElapsedMilliseconds;
        if (elapsedMilliseconds > REQUEST_TIME_THRESHOLD)
        {
            var requestName = typeof(TRequest).Name;

            _logger.LogWarning("Long running Request: {Name} ({ElapsedMilliseconds} milliseconds) {@Request}",
            requestName, elapsedMilliseconds, request);
        }

        return response;
    }
}
