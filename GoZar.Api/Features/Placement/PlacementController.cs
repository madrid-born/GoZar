using GoZar.Api.Common.CurrentUser;
using GoZar.Api.Features.Placement.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoZar.Api.Features.Placement;

[ApiController]
[Route("api/placement")]
[Authorize]
public sealed class PlacementController(PlacementService service, ICurrentUser currentUser) : ControllerBase
{
    // TODO : Review HTTP response semantics and API versioning before making these contracts public.
    [HttpPost("sessions")]
    public Task<PlacementSessionResponse> Start(StartPlacementRequest request, CancellationToken cancellationToken) =>
        service.StartAsync(currentUser.RequiredUserId, request, cancellationToken);

    [HttpGet("sessions/{sessionId:guid}")]
    public Task<PlacementSessionResponse> GetSession(Guid sessionId, CancellationToken cancellationToken) =>
        service.GetSessionAsync(currentUser.RequiredUserId, sessionId, cancellationToken);

    [HttpPost("sessions/{sessionId:guid}/answers")]
    public Task<PlacementResultResponse> SubmitAnswer(Guid sessionId, SubmitPlacementAnswerRequest request, CancellationToken cancellationToken) =>
        service.SubmitAnswerAsync(currentUser.RequiredUserId, sessionId, request, cancellationToken);

    [HttpPost("sessions/{sessionId:guid}/complete")]
    public Task<PlacementResultResponse> Complete(Guid sessionId, CancellationToken cancellationToken) =>
        service.CompleteAsync(currentUser.RequiredUserId, sessionId, cancellationToken);
}
