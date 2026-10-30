namespace GoZar.Api.Domain.Users;

public sealed class UserDailyActivity : DomainEntity
{
    public string UserId { get; set; } = string.Empty;
    public DateOnly LocalDate { get; set; }
    public string TimeZoneId { get; set; } = "Asia/Tehran";
    public int CompletedSessions { get; set; } = 0;
    public int ReviewedTargets { get; set; } = 0;
}
