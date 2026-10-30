namespace GoZar.Api.Features.Progress;

public sealed record StreakSummary(int CurrentStreak, int LongestStreak, DateOnly? LastActiveDate);
public sealed class StreakService
{
    public Task RecordSessionCompletionAsync(string userId, Guid sessionId, CancellationToken cancellationToken = default)
    {
        // TODO : Record activity once inside the accepted completion transaction, using the user's chosen timezone.
        throw new NotImplementedException();
    }
    public Task<StreakSummary> GetAsync(string userId, CancellationToken cancellationToken = default)
    {
        // TODO : Calculate current/longest streak including overdue inactivity; timezone changes need a defined policy.
        throw new NotImplementedException();
    }
}
