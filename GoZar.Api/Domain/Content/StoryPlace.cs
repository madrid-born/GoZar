namespace GoZar.Api.Domain.Content;

public sealed class StoryPlace : DomainEntity
{
    public Guid StoryId { get; set; }
    public Guid PlaceId { get; set; }
}
