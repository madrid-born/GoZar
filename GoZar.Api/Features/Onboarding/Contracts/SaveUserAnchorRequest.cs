using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Onboarding.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record SaveUserAnchorRequest(Guid CityId, Guid? PlaceId, [Required, MaxLength(200)] string Label, [Range(-90, 90)] decimal Latitude, [Range(-180, 180)] decimal Longitude);
