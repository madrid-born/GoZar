namespace GoZar.Api.Domain.Geography;

public sealed class StationLine : DomainEntity
{
    public Guid StationPlaceId { get; set; }
    public Guid TransitLineId { get; set; }
    public int Position { get; set; } = 0;
}
