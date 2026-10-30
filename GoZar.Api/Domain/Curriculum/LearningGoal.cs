using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Curriculum;

public sealed class LearningGoal : DomainEntity
{
    public string Code { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
}
