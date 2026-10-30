using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Curriculum;

public sealed class Lesson : DomainEntity
{
    public Guid ChapterId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? TeachingText { get; set; } = null;
    public int Position { get; set; } = 0;
    public int Difficulty { get; set; } = 1;
    public bool IsPublished { get; set; } = false;
}
