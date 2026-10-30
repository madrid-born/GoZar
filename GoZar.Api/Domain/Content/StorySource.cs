using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Content;

public sealed class StorySource : DomainEntity
{
    public Guid StoryId { get; set; }
    public Guid ContentSourceId { get; set; }
}
