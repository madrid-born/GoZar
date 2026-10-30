using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Content;

public sealed class ContentSource : DomainEntity
{
    public string Title { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string? Attribution { get; set; } = null;
    public string? License { get; set; } = null;
    public DateTimeOffset? ReviewedAtUtc { get; set; } = null;
}
