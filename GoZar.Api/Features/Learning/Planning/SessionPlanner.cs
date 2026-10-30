using GoZar.Api.Domain.Learning;
using GoZar.Api.Features.Learning.Contracts;

namespace GoZar.Api.Features.Learning.Planning;

public sealed class SessionPlanner
{
    public Task<LearningSession> PlanAsync(string userId, StartSessionRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Combine due reviews and curriculum-eligible personalized content into a persisted stable session.
        // TODO : Resolve unfinished sessions and day/timezone boundaries; reuse client request IDs on retries.
        throw new NotImplementedException();
    }
}
