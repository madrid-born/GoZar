namespace GoZar.Api.Features.Learning.Planning;

public sealed record RankedPlace(Guid PlaceId, decimal Score, IReadOnlyDictionary<string, decimal> Factors);
public sealed class CandidateRanker
{
    public Task<IReadOnlyList<RankedPlace>> RankAsync(string userId, Guid cityId, IReadOnlyList<Guid> candidatePlaceIds, CancellationToken cancellationToken = default)
    {
        // TODO : Rank by importance, distance to actual geometry, familiar connections, goals and difficulty.
        // TODO : Choose weights and expose explanation factors; center-point distance alone is insufficient for long roads.
        throw new NotImplementedException();
    }
}
