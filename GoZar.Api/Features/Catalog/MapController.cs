using GoZar.Api.Common.CurrentUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoZar.Api.Features.Catalog;

[ApiController, Authorize, Route("api/map")]
public sealed class MapController(MapService service, ICurrentUser currentUser) : ControllerBase
{
    [HttpGet]
    public Task<Contracts.MapViewportResponse> Get([FromQuery] Contracts.MapViewportQuery query, CancellationToken cancellationToken) =>
        service.GetViewportAsync(currentUser.RequiredUserId, query, cancellationToken);
}
