using GoZar.Api.Features.Catalog.Contracts;

namespace GoZar.Api.Features.Learning.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record LessonResponse(Guid Id, string Title, string? TeachingText, IReadOnlyList<PlaceSummaryResponse> Places);
