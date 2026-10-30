namespace GoZar.Api.Domain.Learning;

public sealed class UserSkillProgress : DomainEntity
{
    // TODO : Choose scheduler state and mastery thresholds; successful answers across sessions must matter.
    public string UserId { get; set; } = string.Empty;
    public Guid LearningTargetId { get; set; }
    public string SkillCode { get; set; } = string.Empty;
    public string Status { get; set; } = "introduced";
    public int Attempts { get; set; } = 0;
    public int CorrectAnswers { get; set; } = 0;
    public DateTimeOffset? LastReviewedAtUtc { get; set; } = null;
    public DateTimeOffset? NextReviewAtUtc { get; set; } = null;
    public string? SchedulerStateJson { get; set; } = null;
}
