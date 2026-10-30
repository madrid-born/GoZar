namespace GoZar.Api.Domain.Learning;

public sealed class AnswerSubmission : DomainEntity
{
    public string UserId { get; set; } = string.Empty;
    public Guid ExerciseId { get; set; }
    public Guid ClientSubmissionId { get; set; }
    public Guid? SelectedOptionId { get; set; } = null;
    public string AnswerJson { get; set; } = "{}";
    public bool IsCorrect { get; set; } = false;
    public int ScoreAwarded { get; set; } = 0;
    public DateTimeOffset AnsweredAtUtc { get; set; }
}
