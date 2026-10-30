namespace GoZar.Api.Domain.Learning;

public sealed class ExerciseOption : DomainEntity
{
    // Answer keys are persistence-only. Never serialize this entity as a public exercise response.
    public Guid ExerciseId { get; set; }
    public string Text { get; set; } = string.Empty;
    public int Position { get; set; } = 0;
    public bool IsCorrect { get; set; } = false;
}
