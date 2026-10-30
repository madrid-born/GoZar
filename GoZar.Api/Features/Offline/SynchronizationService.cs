using GoZar.Api.Models;
using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Offline.Contracts;
namespace GoZar.Api.Features.Offline;

public sealed class SynchronizationService(AppDbContext db, TimeProvider clock)
{
    private readonly AppDbContext _db = db;
    private readonly TimeProvider _clock = clock;
    // TODO : Bound batch size and verify every session owner. Reuse LearningSessionService answer handling, deduplicate, and never trust device time for rewards.
    // TODO : Inject the feature policies/planners below as each operation is implemented.
    public Task<SynchronizationResultResponse> SubmitAnswersAsync(string userId, SubmitAnswerBatchRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Implement SubmitAnswers with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("SynchronizationService.SubmitAnswersAsync");
    }
}
