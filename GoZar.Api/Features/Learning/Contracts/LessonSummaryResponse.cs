namespace GoZar.Api.Features.Learning.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record LessonSummaryResponse(Guid Id, string Title, int Position, string Status);
