using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Administration.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record UpsertCityRequest([Required, MaxLength(200)] string Slug, [Required, MaxLength(200)] string NameFa, [MaxLength(200)] string? NameEn, [Required] string TimeZoneId, [Range(-90, 90)] decimal Latitude, [Range(-180, 180)] decimal Longitude);
