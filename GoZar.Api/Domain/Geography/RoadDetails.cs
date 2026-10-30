namespace GoZar.Api.Domain.Geography;

public sealed class RoadDetails : DomainEntity
{
    public Guid PlaceId { get; set; }
    public string RoadClass { get; set; } = string.Empty;
    public bool IsOneWay { get; set; } = false;
}
