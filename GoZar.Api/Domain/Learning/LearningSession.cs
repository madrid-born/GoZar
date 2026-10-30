namespace GoZar.Api.Domain.Learning;

public sealed class LearningSession : DomainEntity
{
    public string UserId { get; set; } = string.Empty;
    public Guid CityId { get; set; }
    public Guid? ChapterId { get; set; } = null;
    public Guid ClientRequestId { get; set; }
    public string SessionKind { get; set; } = "daily";
    public string Status { get; set; } = "in_progress";
    public int ContentVersion { get; set; } = 1;
    public DateTimeOffset? CompletedAtUtc { get; set; } = null;
}
