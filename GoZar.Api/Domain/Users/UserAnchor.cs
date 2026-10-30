using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Users;

public sealed class UserAnchor : DomainEntity
{
    public string UserId { get; set; } = string.Empty;
    public Guid CityId { get; set; }
    public Guid? PlaceId { get; set; } = null;
    public string Label { get; set; } = string.Empty;
    public decimal Latitude { get; set; } = 0;
    public decimal Longitude { get; set; } = 0;
}
