namespace Shared.Library.Bus.Configuration;

public record RetryConfiguration
{
    /// <summary>
    /// Immediate retry policy with the specified number of retries, with no
    /// delay between attempts. Default is two (2)
    /// </summary>
    public int ImmediateRetries { get; init; } = 2;

    /// <summary>
    /// Interval based retry policy with the specified intervals. The retry count equals
    /// the number of intervals provided, Default in three(3) intervals set at One(1), Five(5) and Ten(10) minutes.
    /// </summary>
    public TimeSpan[] DelayedRedeliveryIntervals { get; init; } = [TimeSpan.FromMinutes(1), TimeSpan.FromMinutes(5), TimeSpan.FromMinutes(10)];
}

