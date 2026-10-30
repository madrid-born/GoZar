using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Content;

public sealed class Story : DomainEntity
{
    public Guid CityId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public string? ImageStorageKey { get; set; } = null;
    public bool IsPublished { get; set; } = false;
}
