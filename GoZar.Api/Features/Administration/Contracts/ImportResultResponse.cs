namespace GoZar.Api.Features.Administration.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record ImportResultResponse(Guid JobId, string Status, int ImportedCount, int SkippedCount);
