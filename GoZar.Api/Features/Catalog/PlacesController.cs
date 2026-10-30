using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GoZar.Api.Common.CurrentUser;
using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Catalog.Contracts;
namespace GoZar.Api.Features.Catalog;

[ApiController]
[Route("api/places")]
[Authorize]
public sealed class PlacesController(CatalogService service) : ControllerBase
{
    // TODO : Review HTTP response semantics and API versioning before making these contracts public.
    [HttpGet]
    public Task<PagedResponse<PlaceSummaryResponse>> SearchPlaces([FromQuery] PlaceQuery query, CancellationToken cancellationToken) =>
        service.SearchPlacesAsync(query, cancellationToken);

    [HttpGet("{placeId:guid}")]
    public Task<PlaceDetailsResponse> GetPlace(Guid placeId, CancellationToken cancellationToken) =>
        service.GetPlaceAsync(placeId, cancellationToken);

    [HttpGet("{placeId:guid}/geometry")]
    public Task<PlaceGeometryResponse> GetGeometry(Guid placeId, [FromQuery] int? version, CancellationToken cancellationToken) =>
        service.GetGeometryAsync(placeId, version, cancellationToken);
}
