namespace GoZar.Api.Features.Catalog.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record PlaceSummaryResponse(Guid Id, Guid CityId, string NameFa, string? NameEn, string PlaceType, decimal Latitude, decimal Longitude);
