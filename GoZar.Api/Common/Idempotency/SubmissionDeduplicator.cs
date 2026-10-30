using GoZar.Api.Features.Learning.Contracts;
using GoZar.Api.Models;

namespace GoZar.Api.Common.Idempotency;

public sealed class SubmissionDeduplicator(AppDbContext db)
{
    private readonly AppDbContext _db = db;
    public Task<AnswerResultResponse?> FindAcceptedAnswerAsync(string userId, Guid clientSubmissionId, CancellationToken cancellationToken = default)
    {
        // TODO : Return the original accepted result only after verifying session ownership and identical payload semantics.
        throw new NotImplementedException();
    }
    // TODO : Coordinate idempotency checks and database unique constraints in the SAME answer transaction.
    // TODO : Persist or deterministically reconstruct the original result; never re-award points on retries.
}
