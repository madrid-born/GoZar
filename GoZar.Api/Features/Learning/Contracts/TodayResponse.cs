namespace GoZar.Api.Features.Learning.Contracts;

// TODO : Confirm daily-goal/session preview semantics before connecting the Today screen.
public sealed record TodayResponse(Guid CityId, Guid? ActiveSessionId, int NewPlacesPlanned, int ReviewsDue, int EstimatedMinutes);
