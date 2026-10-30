using GoZar.Api.Features.Learning.Contracts;
using GoZar.Api.Models;

namespace GoZar.Api.Features.Learning;

public sealed class LearningSessionService(AppDbContext db, TimeProvider clock)
{
    private readonly AppDbContext _db = db;
    private readonly TimeProvider _clock = clock;
    // TODO : Verify session ownership and active item; commit answer, progress, rewards and next item atomically. Completion must reflect actual accepted work.
    // TODO : Inject the feature policies/planners below as each operation is implemented.
    public Task<LearningPathResponse> GetPathAsync(string userId, Guid cityId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetPath with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("LearningSessionService.GetPathAsync");
    }

    public Task<IReadOnlyList<LessonSummaryResponse>> GetChapterLessonsAsync(string userId, Guid chapterId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetChapterLessons with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("LearningSessionService.GetChapterLessonsAsync");
    }

    public Task<LessonResponse> GetLessonAsync(string userId, Guid lessonId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetLesson with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("LearningSessionService.GetLessonAsync");
    }

    public Task<LearningSessionResponse> StartAsync(string userId, StartSessionRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Implement Start with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("LearningSessionService.StartAsync");
    }

    public Task<LearningSessionResponse?> GetActiveAsync(string userId, Guid cityId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetActive with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("LearningSessionService.GetActiveAsync");
    }

    public Task<LearningSessionResponse> GetSessionAsync(string userId, Guid sessionId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetSession with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("LearningSessionService.GetSessionAsync");
    }

    public Task<ExerciseResponse> GetExerciseAsync(string userId, Guid sessionId, Guid exerciseId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetExercise with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("LearningSessionService.GetExerciseAsync");
    }

    public Task<LearningSessionResponse> ConfirmIntroductionAsync(string userId, Guid sessionId, ConfirmIntroductionRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Implement ConfirmIntroduction with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("LearningSessionService.ConfirmIntroductionAsync");
    }

    public Task<AnswerResultResponse> SubmitAnswerAsync(string userId, Guid sessionId, SubmitAnswerRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Implement SubmitAnswer with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("LearningSessionService.SubmitAnswerAsync");
    }

    public Task<SessionSummaryResponse> CompleteAsync(string userId, Guid sessionId, CompleteSessionRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Implement Complete with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("LearningSessionService.CompleteAsync");
    }

    public Task<SessionSummaryResponse> GetSummaryAsync(string userId, Guid sessionId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetSummary with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("LearningSessionService.GetSummaryAsync");
    }

    public Task<bool> AbandonAsync(string userId, Guid sessionId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement Abandon with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("LearningSessionService.AbandonAsync");
    }
}
