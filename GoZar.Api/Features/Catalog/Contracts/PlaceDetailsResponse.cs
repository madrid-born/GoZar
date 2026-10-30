namespace GoZar.Api.Features.Catalog.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record PlaceDetailsResponse(PlaceSummaryResponse Place, IReadOnlyList<PlaceAliasResponse> Aliases, IReadOnlyList<PlaceRelationshipResponse> Relationships, IReadOnlyList<PlaceFactResponse> Facts);
