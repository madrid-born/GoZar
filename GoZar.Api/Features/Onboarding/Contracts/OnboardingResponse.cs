namespace GoZar.Api.Features.Onboarding.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record OnboardingResponse(Guid? SelectedCityId, bool IsCompleted, IReadOnlyList<Guid> LearningGoalIds, IReadOnlyList<UserAnchorResponse> Anchors);
