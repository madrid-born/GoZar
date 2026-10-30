using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GoZar.Api.Common.CurrentUser;
using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Learning.Contracts;
namespace GoZar.Api.Features.Learning;

[ApiController]
[Route("api/learning/sessions")]
[Authorize]
public sealed class LearningSessionsController(LearningSessionService service, ICurrentUser currentUser) : ControllerBase
{
    // TODO : Review HTTP response semantics and API versioning before making these contracts public.
    [HttpPost]
    public Task<LearningSessionResponse> Start(StartSessionRequest request, CancellationToken cancellationToken) =>
        service.StartAsync(currentUser.RequiredUserId, request, cancellationToken);

    [HttpGet("active")]
    public Task<LearningSessionResponse?> GetActive([FromQuery] Guid cityId, CancellationToken cancellationToken) =>
        service.GetActiveAsync(currentUser.RequiredUserId, cityId, cancellationToken);

    [HttpGet("{sessionId:guid}")]
    public Task<LearningSessionResponse> GetSession(Guid sessionId, CancellationToken cancellationToken) =>
        service.GetSessionAsync(currentUser.RequiredUserId, sessionId, cancellationToken);

    [HttpGet("{sessionId:guid}/exercises/{exerciseId:guid}")]
    public Task<ExerciseResponse> GetExercise(Guid sessionId, Guid exerciseId, CancellationToken cancellationToken) =>
        service.GetExerciseAsync(currentUser.RequiredUserId, sessionId, exerciseId, cancellationToken);

    [HttpPost("{sessionId:guid}/introductions")]
    public Task<LearningSessionResponse> ConfirmIntroduction(Guid sessionId, ConfirmIntroductionRequest request, CancellationToken cancellationToken) =>
        service.ConfirmIntroductionAsync(currentUser.RequiredUserId, sessionId, request, cancellationToken);

    [HttpPost("{sessionId:guid}/answers")]
    public Task<AnswerResultResponse> SubmitAnswer(Guid sessionId, SubmitAnswerRequest request, CancellationToken cancellationToken) =>
        service.SubmitAnswerAsync(currentUser.RequiredUserId, sessionId, request, cancellationToken);

    [HttpPost("{sessionId:guid}/complete")]
    public Task<SessionSummaryResponse> Complete(Guid sessionId, CompleteSessionRequest request, CancellationToken cancellationToken) =>
        service.CompleteAsync(currentUser.RequiredUserId, sessionId, request, cancellationToken);

    [HttpGet("{sessionId:guid}/summary")]
    public Task<SessionSummaryResponse> GetSummary(Guid sessionId, CancellationToken cancellationToken) =>
        service.GetSummaryAsync(currentUser.RequiredUserId, sessionId, cancellationToken);

    [HttpPost("{sessionId:guid}/abandon")]
    public Task<bool> Abandon(Guid sessionId, CancellationToken cancellationToken) =>
        service.AbandonAsync(currentUser.RequiredUserId, sessionId, cancellationToken);
}
