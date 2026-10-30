namespace GoZar.Api.Infrastructure.BackgroundJobs;

public sealed class ContentPackBuilder
{
    public Task<Guid> EnqueueAsync(Guid cityId, CancellationToken cancellationToken = default)
    {
        // TODO : Choose durable job storage; no fire-and-forget request tasks or automatic background execution yet.
        throw new NotImplementedException();
    }
    public Task BuildAsync(Guid packId, CancellationToken cancellationToken = default)
    {
        // TODO : Produce versioned, validated public learning/map content and checksums atomically.
        // TODO : Never put exercise answer keys, private user anchors or other users' data into shared packs.
        throw new NotImplementedException();
    }
}
