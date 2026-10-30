using System.Text.Json;

namespace GoZar.Api.Features.Catalog.Contracts;

public sealed record MapFeatureResponse(Guid PlaceId, string Name, string PlaceType, string LearningStatus, JsonElement Geometry);
public sealed record MapViewportResponse(Guid CityId, IReadOnlyList<MapFeatureResponse> Features, string Attribution);
// TODO : Review simplified geometry, caching, content versions and per-skill map-state semantics.
