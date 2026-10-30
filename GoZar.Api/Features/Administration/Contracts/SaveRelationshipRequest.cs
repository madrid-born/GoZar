using System.ComponentModel.DataAnnotations;

namespace GoZar.Api.Features.Administration.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record SaveRelationshipRequest(Guid FromPlaceId, Guid ToPlaceId, [Required] string RelationshipType, string? Explanation);
