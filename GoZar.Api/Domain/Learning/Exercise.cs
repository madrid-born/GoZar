using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Learning;

public sealed class Exercise : DomainEntity
{
    // Answer keys are persistence-only. Never serialize this entity as a public exercise response.
    public Guid SessionItemId { get; set; }
    public Guid LearningTargetId { get; set; }
    public string ExerciseType { get; set; } = string.Empty;
    public string SkillCode { get; set; } = string.Empty;
    public string Prompt { get; set; } = string.Empty;
    public string PublicContentJson { get; set; } = "{}";
    public string CorrectAnswerJson { get; set; } = "{}";
    public string? Explanation { get; set; } = null;
}
