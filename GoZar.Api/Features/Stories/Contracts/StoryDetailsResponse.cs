using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Stories.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record StoryDetailsResponse(Guid Id, string Title, string Body, string? ImageUrl, IReadOnlyList<Guid> PlaceIds, IReadOnlyList<GoZar.Api.Features.Catalog.Contracts.SourceResponse> Sources);
