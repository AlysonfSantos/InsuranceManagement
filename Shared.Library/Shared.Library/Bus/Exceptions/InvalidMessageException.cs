namespace Shared.Library.Bus.Exceptions;

public class InvalidMessageException(string? message) : Exception(message);