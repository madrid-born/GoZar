using GoZar.Api.Features.Onboarding.Contracts;
using GoZar.Api.Models;

namespace GoZar.Api.Features.Onboarding;

public sealed class OnboardingService(AppDbContext db, TimeProvider clock)
{
    private readonly AppDbContext _db = db;
    private readonly TimeProvider _clock = clock;
    // TODO : Keep anchors/goals per user and city; validate coordinate ranges, ownership, allowed goal codes and onboarding completion policy.
    // TODO : Inject the feature policies/planners below as each operation is implemented.
    public Task<OnboardingResponse> GetStateAsync(string userId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetState with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("OnboardingService.GetStateAsync");
    }

    public Task<OnboardingResponse> SelectCityAsync(string userId, SelectCityRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Implement SelectCity with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("OnboardingService.SelectCityAsync");
    }

    public Task<IReadOnlyList<LearningGoalResponse>> GetAvailableGoalsAsync(CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetAvailableGoals with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("OnboardingService.GetAvailableGoalsAsync");
    }

    public Task<OnboardingResponse> UpdateGoalsAsync(string userId, UpdateLearningGoalsRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Implement UpdateGoals with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("OnboardingService.UpdateGoalsAsync");
    }

    public Task<IReadOnlyList<UserAnchorResponse>> GetAnchorsAsync(string userId, Guid cityId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetAnchors with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("OnboardingService.GetAnchorsAsync");
    }

    public Task<UserAnchorResponse> CreateAnchorAsync(string userId, SaveUserAnchorRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Implement CreateAnchor with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("OnboardingService.CreateAnchorAsync");
    }

    public Task<UserAnchorResponse> UpdateAnchorAsync(string userId, Guid anchorId, SaveUserAnchorRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Implement UpdateAnchor with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("OnboardingService.UpdateAnchorAsync");
    }

    public Task<bool> DeleteAnchorAsync(string userId, Guid anchorId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement DeleteAnchor with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("OnboardingService.DeleteAnchorAsync");
    }

    public Task<OnboardingResponse> CompleteAsync(string userId, CompleteOnboardingRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Implement Complete with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("OnboardingService.CompleteAsync");
    }
}
