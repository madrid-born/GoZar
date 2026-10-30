using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Administration.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record UpsertStoryRequest(Guid CityId, [Required] string Title, [Required] string Body, string? ImageStorageKey, [Required] IReadOnlyList<Guid> PlaceIds, [Required] IReadOnlyList<Guid> SourceIds);
