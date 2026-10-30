using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Administration.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record UpsertPlaceRequest(Guid CityId, [Required, MaxLength(200)] string Slug, [Required, MaxLength(200)] string NameFa, string? NameEn, [Required] string PlaceType, [Range(0, 100)] int Importance, [Range(-90, 90)] decimal Latitude, [Range(-180, 180)] decimal Longitude);
