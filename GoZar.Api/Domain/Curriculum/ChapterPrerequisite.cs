namespace GoZar.Api.Domain.Curriculum;

public sealed class ChapterPrerequisite : DomainEntity
{
    public Guid ChapterId { get; set; }
    public Guid RequiredChapterId { get; set; }
}
