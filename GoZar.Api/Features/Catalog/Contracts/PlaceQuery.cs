using System.ComponentModel.DataAnnotations;

namespace GoZar.Api.Features.Catalog.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record PlaceQuery(Guid CityId, string? Search = null, string? PlaceType = null, [Range(1, int.MaxValue)] int Page = 1, [Range(1, 100)] int PageSize = 20);
