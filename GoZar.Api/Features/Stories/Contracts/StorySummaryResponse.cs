namespace GoZar.Api.Features.Stories.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record StorySummaryResponse(Guid Id, Guid CityId, string Title, string? ImageUrl);
