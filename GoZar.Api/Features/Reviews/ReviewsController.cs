using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GoZar.Api.Common.CurrentUser;
using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Reviews.Contracts;
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
    public Task<GoZar.Api.Features.Learning.Contracts.LearningSessionResponse> StartReviewSession(GoZar.Api.Features.Learning.Contracts.StartSessionRequest request, CancellationToken cancellationToken) =>
        service.StartReviewSessionAsync(currentUser.RequiredUserId, request, cancellationToken);
}
