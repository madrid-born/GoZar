using System.ComponentModel.DataAnnotations;

namespace GoZar.Api.Features.Administration.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record UpsertSourceRequest([Required] string Title, [Required, Url] string Url, string? Attribution, string? License);
