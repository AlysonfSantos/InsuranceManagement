using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Shared.Library.MediatR.Exceptions;

public class UnhandledException : Exception
{
    public UnhandledException(string message, Exception inner) : base(message, inner)
    {
    }

    [ExcludeFromCodeCoverage]
    protected UnhandledException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base()
    {
    }
}
