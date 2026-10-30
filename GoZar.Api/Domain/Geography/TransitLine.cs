using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Geography;

public sealed class TransitLine : DomainEntity
{
    public Guid CityId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string TransportMode { get; set; } = string.Empty;
    public string? ColorHex { get; set; } = null;
    public bool IsPublished { get; set; } = false;
}
