namespace GoZar.Api.Domain.Users;

public sealed class UserLearningProfile : DomainEntity
{
    public string UserId { get; set; } = string.Empty;
    public Guid? SelectedCityId { get; set; } = null;
    public DateTimeOffset? OnboardingCompletedAtUtc { get; set; } = null;
}
