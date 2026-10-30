using GoZar.Api.Features.Learning.Contracts;
using GoZar.Api.Features.Reviews.Contracts;
using GoZar.Api.Models;

namespace GoZar.Api.Features.Reviews;

public sealed class ReviewService(AppDbContext db, TimeProvider clock)
{
    private readonly AppDbContext _db = db;
    private readonly TimeProvider _clock = clock;
    // TODO : Force review-only planning rather than trusting the client session-kind field; preserve the independent due-review queue.
    // TODO : Inject the feature policies/planners below as each operation is implemented.
    public Task<ReviewQueueResponse> GetDueAsync(string userId, Guid cityId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetDue with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("ReviewService.GetDueAsync");
    }

    public Task<LearningSessionResponse> StartReviewSessionAsync(string userId, StartSessionRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Implement StartReviewSession with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("ReviewService.StartReviewSessionAsync");
    }
}
