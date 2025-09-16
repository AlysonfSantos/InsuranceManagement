using MediatR;
using Shared.Library.MediatR.Exceptions;

namespace Shared.Library.MediatR.Behaviors;

public class UnhandledExceptionBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        try
        {
            return await next();
        }
        catch (Exception ex)
        {
            var requestName = typeof(TRequest).Name;

            throw new UnhandledException($"Unhandled Exception for request {requestName} {@request}", ex);
        }
    }
}
