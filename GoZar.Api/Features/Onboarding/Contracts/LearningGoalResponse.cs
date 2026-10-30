namespace GoZar.Api.Features.Onboarding.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record LearningGoalResponse(Guid Id, string Code, string Title);
