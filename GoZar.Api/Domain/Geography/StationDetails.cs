using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Geography;

public sealed class StationDetails : DomainEntity
{
    public Guid PlaceId { get; set; }
    public string TransportMode { get; set; } = string.Empty;
    public string? StationCode { get; set; } = null;
}
