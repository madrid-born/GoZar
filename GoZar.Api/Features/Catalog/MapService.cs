using GoZar.Api.Features.Catalog.Contracts;

namespace GoZar.Api.Features.Catalog;

public sealed class MapService
{
    public Task<MapViewportResponse> GetViewportAsync(string userId, MapViewportQuery query, CancellationToken cancellationToken = default)
    {
        // TODO : Return a bounded published map layer with this user's progress, stable context and source attribution.
        // TODO : Avoid loading the whole city for every viewport and avoid interpreting introduction as mastery.
        throw new NotImplementedException();
    }
}
