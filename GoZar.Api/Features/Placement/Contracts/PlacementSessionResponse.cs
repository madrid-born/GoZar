using GoZar.Api.Features.Learning.Contracts;

namespace GoZar.Api.Features.Placement.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record PlacementSessionResponse(Guid SessionId, IReadOnlyList<ExerciseResponse> Exercises);
