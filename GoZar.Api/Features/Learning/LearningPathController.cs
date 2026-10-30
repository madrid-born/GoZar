using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GoZar.Api.Common.CurrentUser;
using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Learning.Contracts;
namespace GoZar.Api.Features.Learning;

[ApiController]
[Route("api/learning")]
[Authorize]
public sealed class LearningPathController(LearningSessionService service, ICurrentUser currentUser) : ControllerBase
{
    // TODO : Review HTTP response semantics and API versioning before making these contracts public.
    [HttpGet("path")]
    public Task<LearningPathResponse> GetPath([FromQuery] Guid cityId, CancellationToken cancellationToken) =>
        service.GetPathAsync(currentUser.RequiredUserId, cityId, cancellationToken);

    [HttpGet("chapters/{chapterId:guid}/lessons")]
    public Task<IReadOnlyList<LessonSummaryResponse>> GetChapterLessons(Guid chapterId, CancellationToken cancellationToken) =>
        service.GetChapterLessonsAsync(currentUser.RequiredUserId, chapterId, cancellationToken);

    [HttpGet("lessons/{lessonId:guid}")]
    public Task<LessonResponse> GetLesson(Guid lessonId, CancellationToken cancellationToken) =>
        service.GetLessonAsync(currentUser.RequiredUserId, lessonId, cancellationToken);
}
