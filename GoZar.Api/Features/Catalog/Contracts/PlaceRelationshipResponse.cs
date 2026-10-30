using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Catalog.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record PlaceRelationshipResponse(Guid Id, Guid FromPlaceId, Guid ToPlaceId, string RelationshipType, string? Explanation);
