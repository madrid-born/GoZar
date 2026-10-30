namespace GoZar.Api.Data.Importing;

public sealed class OsmImportService
{
    public Task<GoZar.Api.Features.Administration.Contracts.ImportResultResponse> ImportAsync(GoZar.Api.Features.Administration.Contracts.ImportCatalogRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Read an approved uploaded snapshot, validate geometry, aliases and licensing; support dry runs and stable external IDs.
        // TODO : Reconsider unstable OSM segment-derived IDs and detect catalog updates without losing learning history.
        throw new NotImplementedException();
    }
}
