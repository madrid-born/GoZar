using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GoZar.Api.Common.CurrentUser;
using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Onboarding.Contracts;
namespace GoZar.Api.Features.Onboarding;

[ApiController]
[Route("api/onboarding")]
[Authorize]
public sealed class OnboardingController(OnboardingService service, ICurrentUser currentUser) : ControllerBase
{
    // TODO : Review HTTP response semantics and API versioning before making these contracts public.
    [HttpGet]
    public Task<OnboardingResponse> GetState(CancellationToken cancellationToken) =>
        service.GetStateAsync(currentUser.RequiredUserId, cancellationToken);

    [HttpPut("city")]
    public Task<OnboardingResponse> SelectCity(SelectCityRequest request, CancellationToken cancellationToken) =>
        service.SelectCityAsync(currentUser.RequiredUserId, request, cancellationToken);

    [HttpGet("goals")]
    public Task<IReadOnlyList<LearningGoalResponse>> GetAvailableGoals(CancellationToken cancellationToken) =>
        service.GetAvailableGoalsAsync(cancellationToken);

    [HttpPut("goals")]
    public Task<OnboardingResponse> UpdateGoals(UpdateLearningGoalsRequest request, CancellationToken cancellationToken) =>
        service.UpdateGoalsAsync(currentUser.RequiredUserId, request, cancellationToken);

    [HttpGet("anchors")]
    public Task<IReadOnlyList<UserAnchorResponse>> GetAnchors([FromQuery] Guid cityId, CancellationToken cancellationToken) =>
        service.GetAnchorsAsync(currentUser.RequiredUserId, cityId, cancellationToken);

    [HttpPost("anchors")]
    public Task<UserAnchorResponse> CreateAnchor(SaveUserAnchorRequest request, CancellationToken cancellationToken) =>
        service.CreateAnchorAsync(currentUser.RequiredUserId, request, cancellationToken);

    [HttpPut("anchors/{anchorId:guid}")]
    public Task<UserAnchorResponse> UpdateAnchor(Guid anchorId, SaveUserAnchorRequest request, CancellationToken cancellationToken) =>
        service.UpdateAnchorAsync(currentUser.RequiredUserId, anchorId, request, cancellationToken);

    [HttpDelete("anchors/{anchorId:guid}")]
    public Task<bool> DeleteAnchor(Guid anchorId, CancellationToken cancellationToken) =>
        service.DeleteAnchorAsync(currentUser.RequiredUserId, anchorId, cancellationToken);

    [HttpPost("complete")]
    public Task<OnboardingResponse> Complete(CompleteOnboardingRequest request, CancellationToken cancellationToken) =>
        service.CompleteAsync(currentUser.RequiredUserId, request, cancellationToken);
}
