using GoZar.Api.Common.CurrentUser;
using GoZar.Api.Features.Learning.Contracts;
using GoZar.Api.Features.Reviews.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoZar.Api.Features.Reviews;

[ApiController]
[Route("api/reviews")]
[Authorize]
public sealed class ReviewsController(ReviewService service, ICurrentUser currentUser) : ControllerBase
{
    // TODO : Review HTTP response semantics and API versioning before making these contracts public.
    [HttpGet]
    public Task<ReviewQueueResponse> GetDue([FromQuery] Guid cityId, CancellationToken cancellationToken) =>
        service.GetDueAsync(currentUser.RequiredUserId, cityId, cancellationToken);

    [HttpPost("sessions")]
    public Task<LearningSessionResponse> StartReviewSession(StartSessionRequest request, CancellationToken cancellationToken) =>
        service.StartReviewSessionAsync(currentUser.RequiredUserId, request, cancellationToken);
}
