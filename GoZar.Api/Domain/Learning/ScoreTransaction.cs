using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Learning;

public sealed class ScoreTransaction : DomainEntity
{
    public string UserId { get; set; } = string.Empty;
    public Guid AnswerSubmissionId { get; set; }
    public int Amount { get; set; } = 0;
}
