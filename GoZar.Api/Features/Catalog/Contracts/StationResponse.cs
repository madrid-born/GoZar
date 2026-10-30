namespace GoZar.Api.Features.Catalog.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record StationResponse(Guid PlaceId, string Name, int Position);
