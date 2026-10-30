using System.ComponentModel.DataAnnotations;

namespace GoZar.Api.Features.Profile.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record UpdatePreferencesRequest([Range(1, 120)] int DailyGoalMinutes, [Required, MaxLength(20)] string LanguageCode, [Required, MaxLength(200)] string TimeZoneId, bool RemindersEnabled, TimeOnly? ReminderLocalTime);
