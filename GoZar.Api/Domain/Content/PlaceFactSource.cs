namespace GoZar.Api.Domain.Content;

public sealed class PlaceFactSource : DomainEntity
{
    public Guid PlaceFactId { get; set; }
    public Guid ContentSourceId { get; set; }
}
