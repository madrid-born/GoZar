using System.Text.Json;

namespace GoZar.Api.Features.Catalog.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record PlaceGeometryResponse(Guid PlaceId, int Version, JsonElement Geometry, string? Attribution);
