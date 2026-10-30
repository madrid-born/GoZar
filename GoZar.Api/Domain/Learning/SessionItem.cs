using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Learning;

public sealed class SessionItem : DomainEntity
{
    public Guid LearningSessionId { get; set; }
    public Guid? LessonId { get; set; } = null;
    public Guid? LearningTargetId { get; set; } = null;
    public int Position { get; set; } = 0;
    public string ItemKind { get; set; } = "exercise";
    public DateTimeOffset? IntroducedAtUtc { get; set; } = null;
}
