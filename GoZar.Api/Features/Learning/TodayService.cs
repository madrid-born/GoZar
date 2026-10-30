namespace GoZar.Api.Features.Learning;

public sealed class TodayService
{
    public Task<Contracts.TodayResponse> GetAsync(string userId, Guid cityId, CancellationToken cancellationToken = default)
    {
        // TODO : Preview the user's available session without introducing places or consuming review items.
        throw new NotImplementedException();
    }
}
