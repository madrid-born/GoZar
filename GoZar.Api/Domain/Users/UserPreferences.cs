namespace GoZar.Api.Domain.Users;

public sealed class UserPreferences : DomainEntity
{
    // TODO : Confirm timezone identifiers and defaults for cross-platform clients; avoid hard-coded UTC offsets.
    public string UserId { get; set; } = string.Empty;
    public int DailyGoalMinutes { get; set; } = 5;
    public string LanguageCode { get; set; } = "fa";
    public string TimeZoneId { get; set; } = "Asia/Tehran";
    public bool RemindersEnabled { get; set; } = false;
    public TimeOnly? ReminderLocalTime { get; set; } = null;
}
