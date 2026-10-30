using System.ComponentModel.DataAnnotations;

namespace GoZar.Api.Features.Administration.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record SaveAliasRequest([Required] string Name, [Required] string LanguageCode, [Required] string AliasType);
