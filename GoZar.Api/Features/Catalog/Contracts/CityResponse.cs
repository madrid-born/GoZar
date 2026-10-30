namespace GoZar.Api.Features.Catalog.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record CityResponse(Guid Id, string Slug, string NameFa, string? NameEn);
