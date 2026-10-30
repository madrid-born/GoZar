using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GoZar.Api.Common.CurrentUser;
using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Catalog.Contracts;
namespace GoZar.Api.Features.Catalog;

[ApiController]
[Route("api/cities")]
[Authorize]
public sealed class CitiesController(CatalogService service) : ControllerBase
{
    // TODO : Review HTTP response semantics and API versioning before making these contracts public.
    [HttpGet]
    public Task<IReadOnlyList<CityResponse>> GetCities(CancellationToken cancellationToken) =>
        service.GetCitiesAsync(cancellationToken);

    [HttpGet("{cityId:guid}")]
    public Task<CityResponse> GetCity(Guid cityId, CancellationToken cancellationToken) =>
        service.GetCityAsync(cityId, cancellationToken);

    [HttpGet("{cityId:guid}/transit-lines")]
    public Task<IReadOnlyList<TransitLineResponse>> GetTransitLines(Guid cityId, CancellationToken cancellationToken) =>
        service.GetTransitLinesAsync(cityId, cancellationToken);

    [HttpGet("{cityId:guid}/transit-lines/{lineId:guid}/stations")]
    public Task<IReadOnlyList<StationResponse>> GetLineStations(Guid cityId, Guid lineId, CancellationToken cancellationToken) =>
        service.GetLineStationsAsync(cityId, lineId, cancellationToken);
}
