using GoZar.Api.Features.Offline.Contracts;
using GoZar.Api.Models;

namespace GoZar.Api.Features.Offline;

public sealed class ContentPackService(AppDbContext db, TimeProvider clock)
{
    private readonly AppDbContext _db = db;
    private readonly TimeProvider _clock = clock;
    // TODO : Inject the feature policies/planners below as each operation is implemented.
    public Task<IReadOnlyList<ContentPackManifestResponse>> GetAvailableAsync(Guid cityId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetAvailable with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("ContentPackService.GetAvailableAsync");
    }

    public Task<ContentPackManifestResponse> GetManifestAsync(Guid packId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetManifest with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("ContentPackService.GetManifestAsync");
    }
}
