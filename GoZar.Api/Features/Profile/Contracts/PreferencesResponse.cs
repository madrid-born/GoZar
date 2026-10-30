namespace GoZar.Api.Features.Profile.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record PreferencesResponse(int DailyGoalMinutes, string LanguageCode, string TimeZoneId, bool RemindersEnabled, TimeOnly? ReminderLocalTime);
