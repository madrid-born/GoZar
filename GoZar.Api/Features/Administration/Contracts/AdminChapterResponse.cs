namespace GoZar.Api.Features.Administration.Contracts;
// TODO : Review editorial read models and concurrency tokens before enabling writes.
public sealed record AdminChapterResponse(Guid Id, UpsertChapterRequest Content, string RowVersion);
