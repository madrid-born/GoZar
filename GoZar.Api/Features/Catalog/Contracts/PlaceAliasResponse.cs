namespace GoZar.Api.Features.Catalog.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record PlaceAliasResponse(Guid Id, string Name, string LanguageCode, string AliasType);
