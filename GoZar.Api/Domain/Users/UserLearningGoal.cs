namespace GoZar.Api.Domain.Users;

public sealed class UserLearningGoal : DomainEntity
{
    public string UserId { get; set; } = string.Empty;
    public Guid LearningGoalId { get; set; }
    public Guid CityId { get; set; }
}
