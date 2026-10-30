using GoZar.Api.Common.CurrentUser;
using GoZar.Api.Features.Catalog.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoZar.Api.Features.Catalog;

[ApiController, Authorize, Route("api/map")]
public sealed class MapController(MapService service, ICurrentUser currentUser) : ControllerBase
{
    [HttpGet]
    public Task<MapViewportResponse> Get([FromQuery] MapViewportQuery query, CancellationToken cancellationToken) =>
        service.GetViewportAsync(currentUser.RequiredUserId, query, cancellationToken);
}
