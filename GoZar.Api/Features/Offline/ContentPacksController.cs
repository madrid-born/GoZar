using GoZar.Api.Features.Offline.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoZar.Api.Features.Offline;

[ApiController]
[Route("api/content-packs")]
[Authorize]
public sealed class ContentPacksController(ContentPackService service) : ControllerBase
{
    // TODO : Review HTTP response semantics and API versioning before making these contracts public.
    [HttpGet]
    public Task<IReadOnlyList<ContentPackManifestResponse>> GetAvailable([FromQuery] Guid cityId, CancellationToken cancellationToken) =>
        service.GetAvailableAsync(cityId, cancellationToken);

    [HttpGet("{packId:guid}/manifest")]
    public Task<ContentPackManifestResponse> GetManifest(Guid packId, CancellationToken cancellationToken) =>
        service.GetManifestAsync(packId, cancellationToken);
}
