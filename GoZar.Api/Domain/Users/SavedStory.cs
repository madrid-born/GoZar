using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Users;

public sealed class SavedStory : DomainEntity
{
    public string UserId { get; set; } = string.Empty;
    public Guid StoryId { get; set; }
}
