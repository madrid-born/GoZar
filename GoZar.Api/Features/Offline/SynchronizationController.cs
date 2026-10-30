using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GoZar.Api.Common.CurrentUser;
using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Offline.Contracts;
namespace GoZar.Api.Features.Offline;

[ApiController]
[Route("api/synchronization")]
[Authorize]
public sealed class SynchronizationController(SynchronizationService service, ICurrentUser currentUser) : ControllerBase
{
    // TODO : Review HTTP response semantics and API versioning before making these contracts public.
    [HttpPost("answers")]
    public Task<SynchronizationResultResponse> SubmitAnswers(SubmitAnswerBatchRequest request, CancellationToken cancellationToken) =>
        service.SubmitAnswersAsync(currentUser.RequiredUserId, request, cancellationToken);
}
