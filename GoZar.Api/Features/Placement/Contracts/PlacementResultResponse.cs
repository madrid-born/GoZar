namespace GoZar.Api.Features.Placement.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record PlacementResultResponse(Guid SessionId, bool IsCompleted, string Summary);
