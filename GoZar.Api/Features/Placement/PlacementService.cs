using GoZar.Api.Models;
using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Placement.Contracts;
namespace GoZar.Api.Features.Placement;

public sealed class PlacementService(AppDbContext db, TimeProvider clock)
{
    private readonly AppDbContext _db = db;
    private readonly TimeProvider _clock = clock;
    // TODO : Inject the feature policies/planners below as each operation is implemented.
    public Task<PlacementSessionResponse> StartAsync(string userId, StartPlacementRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Implement Start with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("PlacementService.StartAsync");
    }

    public Task<PlacementSessionResponse> GetSessionAsync(string userId, Guid sessionId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetSession with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("PlacementService.GetSessionAsync");
    }

    public Task<PlacementResultResponse> SubmitAnswerAsync(string userId, Guid sessionId, SubmitPlacementAnswerRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Implement SubmitAnswer with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("PlacementService.SubmitAnswerAsync");
    }

    public Task<PlacementResultResponse> CompleteAsync(string userId, Guid sessionId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement Complete with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("PlacementService.CompleteAsync");
    }
}
