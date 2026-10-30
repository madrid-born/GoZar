namespace GoZar.Api.Features.Learning.Planning;

public sealed class SessionPlanner
{
    public Task<GoZar.Api.Domain.Learning.LearningSession> PlanAsync(string userId, GoZar.Api.Features.Learning.Contracts.StartSessionRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Combine due reviews and curriculum-eligible personalized content into a persisted stable session.
        // TODO : Resolve unfinished sessions and day/timezone boundaries; reuse client request IDs on retries.
        throw new NotImplementedException();
    }
}
