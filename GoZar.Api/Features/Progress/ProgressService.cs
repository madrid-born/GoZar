using GoZar.Api.Models;
using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Progress.Contracts;
namespace GoZar.Api.Features.Progress;

public sealed class ProgressService(AppDbContext db, TimeProvider clock)
{
    private readonly AppDbContext _db = db;
    private readonly TimeProvider _clock = clock;
    // TODO : Inject the feature policies/planners below as each operation is implemented.
    public Task<ProgressSummaryResponse> GetSummaryAsync(string userId, Guid cityId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetSummary with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("ProgressService.GetSummaryAsync");
    }

    public Task<PlaceProgressResponse> GetPlaceProgressAsync(string userId, Guid placeId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetPlaceProgress with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("ProgressService.GetPlaceProgressAsync");
    }

    public Task<IReadOnlyList<DailyActivityResponse>> GetActivityAsync(string userId, DateOnly from, DateOnly to, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetActivity with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("ProgressService.GetActivityAsync");
    }
}
