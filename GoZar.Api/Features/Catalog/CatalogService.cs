using GoZar.Api.Models;
using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Catalog.Contracts;
namespace GoZar.Api.Features.Catalog;

public sealed class CatalogService(AppDbContext db, TimeProvider clock)
{
    private readonly AppDbContext _db = db;
    private readonly TimeProvider _clock = clock;
    // TODO : Read only published content; use bounded queries, cancellation and explicit DTO projection, never serialize EF entities.
    // TODO : Inject the feature policies/planners below as each operation is implemented.
    public Task<IReadOnlyList<CityResponse>> GetCitiesAsync(CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetCities with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("CatalogService.GetCitiesAsync");
    }

    public Task<CityResponse> GetCityAsync(Guid cityId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetCity with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("CatalogService.GetCityAsync");
    }

    public Task<IReadOnlyList<TransitLineResponse>> GetTransitLinesAsync(Guid cityId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetTransitLines with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("CatalogService.GetTransitLinesAsync");
    }

    public Task<IReadOnlyList<StationResponse>> GetLineStationsAsync(Guid cityId, Guid lineId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetLineStations with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("CatalogService.GetLineStationsAsync");
    }

    public Task<PagedResponse<PlaceSummaryResponse>> SearchPlacesAsync(PlaceQuery query, CancellationToken cancellationToken = default)
    {
        // TODO : Implement SearchPlaces with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("CatalogService.SearchPlacesAsync");
    }

    public Task<PlaceDetailsResponse> GetPlaceAsync(Guid placeId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetPlace with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("CatalogService.GetPlaceAsync");
    }

    public Task<PlaceGeometryResponse> GetGeometryAsync(Guid placeId, int? version, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetGeometry with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("CatalogService.GetGeometryAsync");
    }
}
