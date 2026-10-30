using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Administration.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record UpsertTransitLineRequest(Guid CityId, [Required] string Name, [Required] string TransportMode, string? ColorHex);
