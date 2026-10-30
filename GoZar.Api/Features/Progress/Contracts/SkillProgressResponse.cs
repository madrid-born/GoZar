namespace GoZar.Api.Features.Progress.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record SkillProgressResponse(string SkillCode, string Status, int Attempts, int CorrectAnswers, DateTimeOffset? NextReviewAtUtc);
