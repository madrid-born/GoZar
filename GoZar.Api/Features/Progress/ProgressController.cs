using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GoZar.Api.Common.CurrentUser;
using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Progress.Contracts;
namespace GoZar.Api.Features.Progress;

[ApiController]
[Route("api/progress")]
[Authorize]
public sealed class ProgressController(ProgressService service, ICurrentUser currentUser) : ControllerBase
{
    // TODO : Review HTTP response semantics and API versioning before making these contracts public.
    [HttpGet]
    public Task<ProgressSummaryResponse> GetSummary([FromQuery] Guid cityId, CancellationToken cancellationToken) =>
        service.GetSummaryAsync(currentUser.RequiredUserId, cityId, cancellationToken);

    [HttpGet("places/{placeId:guid}")]
    public Task<PlaceProgressResponse> GetPlaceProgress(Guid placeId, CancellationToken cancellationToken) =>
        service.GetPlaceProgressAsync(currentUser.RequiredUserId, placeId, cancellationToken);

    [HttpGet("activity")]
    public Task<IReadOnlyList<DailyActivityResponse>> GetActivity([FromQuery] DateOnly from, [FromQuery] DateOnly to, CancellationToken cancellationToken) =>
        service.GetActivityAsync(currentUser.RequiredUserId, from, to, cancellationToken);
}
